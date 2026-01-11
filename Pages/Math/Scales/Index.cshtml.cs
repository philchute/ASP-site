using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP_site.Models;
using ASP_site.Services;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Text;
using System.Globalization;

namespace ASP_site.Pages.MathSection.Scales;

public class IndexModel : PageModel
{
    private readonly ScaleConverterService _converter;
    private readonly IWebHostEnvironment _env;

    public IndexModel(ScaleConverterService converter, IWebHostEnvironment env)
    {
        _converter = converter;
        _env = env;
        Scales = _converter.GetCommonScales();
        ReferenceObjects = _converter.GetReferenceObjects();
    }

    public List<ScaleModel> Scales { get; }
    public List<ReferenceObject> ReferenceObjects { get; }

    [BindProperty(SupportsGet = true)]
    public double SelectedRatio { get; set; } = 144.0; // Default to 1:144

    public ScaleModel SelectedScale => Scales.FirstOrDefault(s => System.Math.Abs(s.Ratio - SelectedRatio) < 0.01) 
                                       ?? new ScaleModel("Custom", SelectedRatio, "Custom", "Custom user-defined scale.");

    public void OnGet()
    {
        // View logic
    }

    public IActionResult OnGetDownloadPdf(double ratio)
    {
        // Find or create scale
        var scale = Scales.FirstOrDefault(s => System.Math.Abs(s.Ratio - ratio) < 0.01) 
                    ?? new ScaleModel($"1:{ratio}", ratio, "Custom", "Custom Scale");

        // Disable debugging
        QuestPDF.Settings.EnableDebugging = false; 

        var document = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(1, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(10));

                // Calculate safe content width
                // A4 Width (595.28) - 2 * Margin (28.35) = 538.58 pts
                float pageWidthPts = PageSizes.A4.Width;
                float marginPts = (float)Unit.Centimetre;
                float pageContentWidth = pageWidthPts - 2 * marginPts;
                
                // Use a larger safety buffer to prevent overflow
                // A4 Width (595pts) - Margins (56pts) = 539pts available.
                // We use 480pts as safe width to be absolutely sure.
                float safeWidth = pageContentWidth - 60;

                page.Header()
                    .Column(c =>
                    {
                        c.Item().Text($"Scale Reference Sheet - {scale.Name}")
                            .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);
                        
                        c.Item().Text("IMPORTANT: Print at 100% Scale / Actual Size. Do not use 'Fit to Page'. Verify accuracy with the Calibration Square.")
                            .FontSize(9).FontColor(Colors.Red.Medium).Bold();
                    });

                page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x =>
                    {
                        x.Spacing(15);

                        // Description
                        x.Item().Text(scale.Description).Italic();

                        // 1. Calibration Row
                        x.Item().Row(row =>
                        {
                            row.Spacing(20);
                            
                            // 1-Inch Square
                            row.AutoItem().Column(c =>
                            {
                                c.Item().Text("Calibration Square (1 inch)").Bold().FontSize(8);
                                
                                string svgContent = @"
                                    <svg width=""72"" height=""72"" viewBox=""0 0 72 72"" xmlns=""http://www.w3.org/2000/svg"">
                                        <rect x=""0.5"" y=""0.5"" width=""71"" height=""71"" fill=""none"" stroke=""black"" stroke-width=""1""/>
                                        <text x=""36"" y=""40"" font-family=""Arial"" font-size=""10"" text-anchor=""middle"" fill=""black"">1 inch</text>
                                    </svg>";

                                c.Item().Width(72).Height(72).Svg(svgContent);
                            });

                            // US Quarter
                            double quarterMm = 24.26;
                            double quarterPoints = _converter.ToPoints(quarterMm);
                            float qpFloat = (float)quarterPoints;
                            
                            row.AutoItem().Column(c =>
                            {
                                c.Item().Text("US Quarter (24.26mm)").Bold().FontSize(8);
                                
                                string w = (qpFloat + 2).ToString("F2", CultureInfo.InvariantCulture);
                                string cx = (qpFloat / 2 + 1).ToString("F2", CultureInfo.InvariantCulture);
                                string r = (qpFloat / 2).ToString("F2", CultureInfo.InvariantCulture);
                                string textY = (qpFloat / 2 + 5).ToString("F2", CultureInfo.InvariantCulture);

                                string svgContent = $@"
                                    <svg width=""{w}"" height=""{w}"" viewBox=""0 0 {w} {w}"" xmlns=""http://www.w3.org/2000/svg"">
                                        <circle cx=""{cx}"" cy=""{cx}"" r=""{r}"" fill=""none"" stroke=""black"" stroke-width=""1""/>
                                        <text x=""{cx}"" y=""{textY}"" font-family=""Arial"" font-size=""8"" text-anchor=""middle"" fill=""black"">25¢</text>
                                    </svg>";

                                c.Item().Width(qpFloat + 2).Height(qpFloat + 2).Svg(svgContent);
                            });
                        });

                        // 2. Metric Scale Ruler
                        x.Item().Column(c =>
                        {
                            c.Item().Text($"Metric Scale Ruler").Bold();
                            
                            double pointsPerMeter = _converter.ToScalePoints(1000, scale);
                            double stepSizeMeters = 1;
                            
                            // Dynamic step size to ensure readability
                            double minTickSpacing = 30;
                            if (pointsPerMeter < minTickSpacing)
                            {
                                if (pointsPerMeter * 2 >= minTickSpacing) stepSizeMeters = 2;
                                else if (pointsPerMeter * 5 >= minTickSpacing) stepSizeMeters = 5;
                                else if (pointsPerMeter * 10 >= minTickSpacing) stepSizeMeters = 10;
                                else if (pointsPerMeter * 20 >= minTickSpacing) stepSizeMeters = 20;
                                else if (pointsPerMeter * 50 >= minTickSpacing) stepSizeMeters = 50;
                                else if (pointsPerMeter * 100 >= minTickSpacing) stepSizeMeters = 100;
                                else stepSizeMeters = 500; 
                            }

                            // Calculate optimal width
                            // Subtract 40 to account for the extra width added for labels/padding in the SVG container
                            float maxRulerWidth = safeWidth - 40;
                            double oneStepPoints = _converter.ToScalePoints(stepSizeMeters * 1000, scale);
                            
                            // If a SINGLE step is wider than the page, we can't draw a useful ruler
                            if (oneStepPoints > maxRulerWidth)
                            {
                                c.Item().Text("(Scale too large for ruler on A4 page)").Italic().FontSize(8);
                            }
                            else
                            {
                                int stepsToDraw = (int)(maxRulerWidth / oneStepPoints);
                                if (stepsToDraw < 1) stepsToDraw = 1;
                                if (stepsToDraw > 20) stepsToDraw = 20; // Cap max ticks

                                float scaleLengthPoints = (float)(stepsToDraw * oneStepPoints);
                                float height = 30;

                                var sb = new StringBuilder();
                                string svgW = (scaleLengthPoints + 40).ToString("F2", CultureInfo.InvariantCulture);
                                string svgH = height.ToString("F2", CultureInfo.InvariantCulture);
                                string lineX2 = scaleLengthPoints.ToString("F2", CultureInfo.InvariantCulture);

                                sb.Append($"<svg width=\"{svgW}\" height=\"{svgH}\" xmlns=\"http://www.w3.org/2000/svg\">");
                                sb.Append($"<line x1=\"0\" y1=\"10\" x2=\"{lineX2}\" y2=\"10\" stroke=\"black\" stroke-width=\"1\" />");

                                for (int i = 0; i <= stepsToDraw; i++)
                                {
                                    double meters = i * stepSizeMeters;
                                    float xPos = (float)_converter.ToScalePoints(meters * 1000, scale);
                                    string xStr = xPos.ToString("F2", CultureInfo.InvariantCulture);
                                    
                                    sb.Append($"<line x1=\"{xStr}\" y1=\"10\" x2=\"{xStr}\" y2=\"0\" stroke=\"black\" stroke-width=\"1\" />");
                                    
                                    // Label
                                    string label = $"{meters}m";
                                    if (meters >= 1000) label = $"{meters/1000:0.#}km";
                                    
                                    sb.Append($"<text x=\"{xStr}\" y=\"22\" font-family=\"Arial\" font-size=\"8\" text-anchor=\"middle\" fill=\"black\">{label}</text>");
                                }
                                sb.Append("</svg>");
                                
                                c.Item().Width(scaleLengthPoints + 40).Height(height).Svg(sb.ToString());
                            }
                        });

                        // 3. Freedom Scale Ruler
                        x.Item().Column(c =>
                        {
                            c.Item().Text($"Freedom Scale Ruler").Bold();

                            double pointsPerFoot = _converter.ToScalePoints(304.8, scale);
                            int stepSizeFeet = 1;

                            double minTickSpacing = 30;
                            if (pointsPerFoot < minTickSpacing)
                            {
                                if (pointsPerFoot * 2 >= minTickSpacing) stepSizeFeet = 2;
                                else if (pointsPerFoot * 5 >= minTickSpacing) stepSizeFeet = 5;
                                else if (pointsPerFoot * 10 >= minTickSpacing) stepSizeFeet = 10;
                                else if (pointsPerFoot * 20 >= minTickSpacing) stepSizeFeet = 20;
                                else if (pointsPerFoot * 50 >= minTickSpacing) stepSizeFeet = 50;
                                else stepSizeFeet = 100;
                            }
                            
                            float maxRulerWidth = safeWidth - 40;
                            double oneStepPoints = _converter.ToScalePoints(stepSizeFeet * 304.8, scale);

                            if (oneStepPoints > maxRulerWidth)
                            {
                                c.Item().Text("(Scale too large for ruler on A4 page)").Italic().FontSize(8);
                            }
                            else
                            {
                                int stepsToDraw = (int)(maxRulerWidth / oneStepPoints);
                                if (stepsToDraw < 1) stepsToDraw = 1;
                                if (stepsToDraw > 20) stepsToDraw = 20;

                                float scaleLengthPoints = (float)(stepsToDraw * oneStepPoints);
                                float height = 30;
                                
                                var sb = new StringBuilder();
                                string svgW = (scaleLengthPoints + 40).ToString("F2", CultureInfo.InvariantCulture); // Extra width for text overhang
                                string svgH = height.ToString("F2", CultureInfo.InvariantCulture);

                                sb.Append($"<svg width=\"{svgW}\" height=\"{svgH}\" xmlns=\"http://www.w3.org/2000/svg\">");
                                sb.Append($"<line x1=\"0\" y1=\"10\" x2=\"{scaleLengthPoints.ToString(CultureInfo.InvariantCulture)}\" y2=\"10\" stroke=\"black\" stroke-width=\"1\" />");

                                for (int i = 0; i <= stepsToDraw; i++)
                                {
                                    double feet = i * stepSizeFeet;
                                    float xPos = (float)_converter.ToScalePoints(feet * 304.8, scale);
                                    string xStr = xPos.ToString(CultureInfo.InvariantCulture);
                                    
                                    sb.Append($"<line x1=\"{xStr}\" y1=\"10\" x2=\"{xStr}\" y2=\"0\" stroke=\"black\" stroke-width=\"1\" />");
                                    sb.Append($"<text x=\"{xStr}\" y=\"22\" font-family=\"Arial\" font-size=\"8\" text-anchor=\"middle\" fill=\"black\">{feet}'</text>");
                                }
                                
                                sb.Append("</svg>");
                                
                                c.Item().Width(scaleLengthPoints + 40).Height(height).Svg(sb.ToString());
                            }
                        });

                        // 4. Brick Pattern 
                        x.Item().Column(c =>
                        {
                            c.Item().Text("Brick Pattern Reference (Modular: 4\"x8\" nom)").Bold();

                            double brickL = 194; // mm
                            double brickH = 57;  // mm
                            double mortar = 10;  // mm
                            
                            double pitchX_mm = brickL + mortar;
                            double pitchY_mm = brickH + mortar;

                            double pitchX_pts = _converter.ToScalePoints(pitchX_mm, scale);
                            double pitchY_pts = _converter.ToScalePoints(pitchY_mm, scale);

                            // Safety checks
                            if (pitchX_pts < 5 || pitchY_pts < 2)
                            {
                                c.Item().Text("(Brick pattern too small for this scale)").Italic().FontSize(8);
                                return;
                            }
                            if (pitchX_pts > safeWidth)
                            {
                                c.Item().Text("(Brick pattern too large for this page)").Italic().FontSize(8);
                                return;
                            }

                            // Calculate grid size
                            // Max height approx 1/3 page or 250pts
                            int rows = (int)(250 / pitchY_pts); 
                            if (rows < 3) rows = 3; // Minimum 3 rows for pattern visibility
                            if (rows > 20) rows = 20; // Cap rows

                            float totalHeightPts = (float)(rows * pitchY_pts);
                            float totalWidthPts = safeWidth;

                            var sb = new StringBuilder();
                            string svgW = totalWidthPts.ToString("F2", CultureInfo.InvariantCulture);
                            string svgH = totalHeightPts.ToString("F2", CultureInfo.InvariantCulture);

                            sb.Append($"<svg width=\"{svgW}\" height=\"{svgH}\" viewBox=\"0 0 {svgW} {svgH}\" xmlns=\"http://www.w3.org/2000/svg\">");
                            
                            // No outer border

                            for (int r = 0; r < rows; r++)
                            {
                                double currentY_mm = r * pitchY_mm;
                                double currentY_pts = _converter.ToScalePoints(currentY_mm, scale);
                                double brickH_pts = _converter.ToScalePoints(brickH, scale); // Actual brick height

                                // Offset every other row
                                double startX_mm = (r % 2 == 0) ? 0 : -(pitchX_mm / 2.0);
                                
                                double currentX_mm = startX_mm;

                                // Draw bricks in this row until we pass safeWidth
                                while (true)
                                {
                                    double currentX_pts = _converter.ToScalePoints(currentX_mm, scale);
                                    
                                    // Check if we are past the right edge
                                    if (currentX_pts >= totalWidthPts) break;

                                    double brickW_pts = _converter.ToScalePoints(brickL, scale);

                                    // Check visibility (is any part of the brick inside 0..totalWidthPts?)
                                    if (currentX_pts + brickW_pts > 0)
                                    {
                                        // Calculate render coordinates
                                        double renderX = Math.Max(0, currentX_pts);
                                        
                                        // If started before 0 (offset row), clip width
                                        if (currentX_pts < 0) 
                                        {
                                            brickW_pts += currentX_pts; // reduce width by the negative part
                                        }

                                        // If extends beyond width, clip width
                                        if (renderX + brickW_pts > totalWidthPts)
                                        {
                                            brickW_pts = totalWidthPts - renderX;
                                        }

                                        if (brickW_pts > 0)
                                        {
                                            string rX = renderX.ToString("F2", CultureInfo.InvariantCulture);
                                            string rY = currentY_pts.ToString("F2", CultureInfo.InvariantCulture);
                                            string rW = brickW_pts.ToString("F2", CultureInfo.InvariantCulture);
                                            string rH = brickH_pts.ToString("F2", CultureInfo.InvariantCulture);

                                            sb.Append($"<rect x=\"{rX}\" y=\"{rY}\" width=\"{rW}\" height=\"{rH}\" fill=\"none\" stroke=\"gray\" stroke-width=\"0.5\" />");
                                        }
                                    }

                                    currentX_mm += pitchX_mm;
                                }
                            }

                            sb.Append("</svg>");
                            c.Item().Width(totalWidthPts).Height(totalHeightPts).Svg(sb.ToString());
                        });


                        // 5. Objects
                        x.Item().Column(col => 
                        {
                            col.Item().Text("Reference Objects").Bold();
                            
                            col.Item().Inlined(inlined =>
                            {
                                inlined.Spacing(20);
                                inlined.VerticalSpacing(20);

                                foreach (var obj in ReferenceObjects)
                                {
                                    float wPts = (float)_converter.ToScalePoints(obj.RealWidthMm, scale);
                                    float hPts = (float)_converter.ToScalePoints(obj.RealHeightMm, scale);

                                    // Filter extremes
                                    if (wPts < 4 || hPts < 4) continue; // Too small
                                    if (wPts > safeWidth / 3) continue; // Too wide for page
                                    if (hPts > 400) continue; // Too tall (approx > 1 page)

                                    // Calculate effective width (Object or Text min-width)
                                    // Add a small buffer (+2) to the container width to ensure the content (wPts) definitely fits inside
                                    float itemWidth = Math.Min(Math.Max(wPts + 2f, 100f), safeWidth);
                                    
                                    inlined.Item().Element(container => 
                                    {
                                        container.Width(itemWidth).Column(c => 
                                        {
                                             // Inner content width - strictly clamped to container width
                                             // We subtract 0.1f to avoid floating point equality issues at the boundary
                                             float innerSafeW = Math.Min(Math.Max(wPts, 1f), itemWidth - 0.1f);
                                             
                                             // Text label
                                             c.Item().MaxWidth(itemWidth).Text(obj.Name).FontSize(8).AlignCenter();
                                             c.Item().MaxWidth(itemWidth).Text($"{obj.RealWidthMm/1000.0:0.##}m x {(obj.RealHeightMm/1000.0):0.##}m").FontSize(6).FontColor(Colors.Grey.Darken2).AlignCenter();
                                             
                                             // Shape
                                             RenderSilhouetteShape(c, obj, innerSafeW, hPts);
                                        });
                                    });
                                }
                            });
                        });
                    });

                page.Footer()
                    .AlignCenter()
                    .Text(x =>
                    {
                        x.Span("www.philchute.com/math/scales");
                        x.Span(" - ");
                        x.CurrentPageNumber();
                    });
            });
        });

        var stream = new MemoryStream();
        document.GeneratePdf(stream);
        stream.Position = 0;

        return File(stream, "application/pdf", $"ScaleReference_{scale.Name.Replace(" ", "_")}.pdf");
    }

    private void RenderSilhouetteShape(ColumnDescriptor c, ReferenceObject obj, float w, float h)
    {
        bool svgRendered = false;

        if (!string.IsNullOrEmpty(obj.SvgFileName))
        {
             try
             {
                 var webRoot = _env.WebRootPath ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                 var filePath = Path.Combine(webRoot, "image", "references", obj.SvgFileName);
                 if (System.IO.File.Exists(filePath))
                 {
                     var svgContent = System.IO.File.ReadAllText(filePath);
                     c.Item().AlignCenter().Width(w).Height(h).Svg(svgContent);
                     svgRendered = true;
                 }
             }
             catch
             {
                 // Fallback
             }
        }

        if (!svgRendered)
        {
            var sb = new StringBuilder();
            string wStr = w.ToString("F2", CultureInfo.InvariantCulture);
            string hStr = h.ToString("F2", CultureInfo.InvariantCulture);
            
            sb.Append($"<svg width=\"{wStr}\" height=\"{hStr}\" viewBox=\"0 0 {wStr} {hStr}\" xmlns=\"http://www.w3.org/2000/svg\">");
            
            if (obj.IsRound) 
            {
                float cx = w / 2.0f;
                float cy = h / 2.0f;
                float r = Math.Min(w, h) / 2.0f;
                
                string cxStr = cx.ToString("F2", CultureInfo.InvariantCulture);
                string cyStr = cy.ToString("F2", CultureInfo.InvariantCulture);
                string rStr = r.ToString("F2", CultureInfo.InvariantCulture);

                sb.Append($"<circle cx=\"{cxStr}\" cy=\"{cyStr}\" r=\"{rStr}\" fill=\"{obj.ColorHex}\" />");
            }
            else
            {
                sb.Append($"<rect width=\"{wStr}\" height=\"{hStr}\" fill=\"{obj.ColorHex}\" />");
            }
            
            sb.Append("</svg>");
            c.Item().AlignCenter().Width(w).Height(h).Svg(sb.ToString());
        }
    }
}
