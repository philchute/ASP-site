using ASP_site.Models;

namespace ASP_site.Services;

/// <summary>
/// Represents a reference object for comparison.
/// </summary>
/// <param name="Name">Display name.</param>
/// <param name="RealHeightMm">Height in mm (for Profile view).</param>
/// <param name="RealWidthMm">Width in mm (for Profile/Overhead view).</param>
/// <param name="RealDepthMm">Depth in mm (for Overhead view).</param>
/// <param name="ColorHex">Display color.</param>
/// <param name="IsRound">If true, overhead view is a circle (width=diameter).</param>
/// <param name="SvgFileName">Optional filename of an SVG in wwwroot/image/references/ for Profile view.</param>
/// <param name="OverheadSvgFileName">Optional filename of an SVG in wwwroot/image/references/ for Overhead view.</param>
public record ReferenceObject(string Name, double RealHeightMm, double RealWidthMm, double RealDepthMm, string ColorHex, bool IsRound = false, string? SvgFileName = null, string? OverheadSvgFileName = null);

public class ScaleConverterService
{
    private const double PointsPerInch = 72.0;
    private const double MillimetersPerInch = 25.4;

    public List<ReferenceObject> GetReferenceObjects()
    {
        return new List<ReferenceObject>
        {
            // Name, RealHeightMm, RealWidthMm, RealDepthMm, ColorHex, IsRound, SvgFileName, OverheadSvgFileName
            new("Soda Can", 122, 66, 66, "#ef4444", true, "soda-can.svg"),
            new("Basketball", 240, 240, 240, "#f97316", true, "basketball.svg", "basketball.svg"), 
            new("Human (1.8m)", 1800, 500, 250, "#3b82f6", true, "human.svg"), 
            new("Space Marine (2.5m)", 2500, 500, 500, "#3b82f6", true, "space-marine.svg"),
            new("Door (2.1m)", 2100, 900, 40, "#64748b", false, "door.svg"), 
            new("Shipping Container (20ft)", 2591, 6058, 2438, "#b91c1c", false, "cargo.svg", "cargo.svg"),
            new("Car", 1450, 4500, 1800, "#10b981", false, "car.svg", "car_top.svg"), 
            new("Tank (M1A1)", 2885, 9830, 3700, "#888888", false, "tank.svg"),
            new("Airplane (737 MAX)", 12290, 35560, 35920, "#0ea5e9", false, "airplane.svg", "airplane_top.svg"),
            new("Gundam (RX-78-2)", 18500, 18500, 18500, "#888888", false, "robot.svg"),
            new("Space Shuttle", 56000, 8700, 8700, "#0ea5e9", true, "space-shuttle.svg", "space-shuttle_side.svg"),
            new("Space Station (ISS)", 73000, 109000, 73000, "#0ea5e9", false, "space-station.svg", "space-station.svg"),
        };
    }
    public List<ScaleModel> GetCommonScales()
    {
        return new List<ScaleModel>
        {
            new("1:1 (1:1)", 1.0, "1:1", "1:1 scale."),
            new("1:4 (Live Steam Trains/Flying Models)", 4.0, "Railroad/Flying", "Live steam trains and flying models."),
            new("1:6 (Playscale / Action Man)", 6.0, "Dollhouse/Figure", "Barbie, G.I. Joe (12 inch), and Playscale miniatures."),
            new("1:8 (Live Steam Trains/Cars/Motorcycles)", 8.0, "Railroad/Auto", "Live steam trains and cars and motorcycles."),
            new("1:10 (RC Cars)", 10.0, "RC/Auto", "Popular scale for Radio Controlled (RC) cars and trucks."),
            new("1:11 (Live Steam Trains)", 11.0, "Railroad", "Live steam trains. Common gauge for Live Steam scaled at 1+1/16 inches to the foot in the UK."),
            new("1:12 (Dollhouse/Cars/Motorcycles)", 12.0, "Dollhouse/Auto", "1 foot to 1 inch scale. Used for model steam trains. Standard dollhouse scale. Action figures."),
            new("1:16 (Live Steam Trains/Cars/Motorcycles)", 16.0, "Railroad/Auto", "Live steam trains and cars and motorcycles."),
            new("1:18 (Action Figures / Diecast)", 18.0, "Figure/Auto", "3.75 inch action figures (Star Wars, G.I. Joe), and diecast cars."),
            new("1:20 (Cars)", 20.0, "Auto", "Cars."),
            new("1:22.5 (G Scale Trains)", 22.5, "Railroad", "Large model trains (G Scale). Known as Gauge 3 in the UK (scaled at 17/32 inch to the foot) and known as Gauge 2+1/2 on the Märklin factory standards."),
            new("1:24 (G Scale/Car)", 24.0, "Railroad/Auto", "Large model trains (G Scale) and detailed car models."),
            new("1:25 (Cars/Trucks)", 25.0, "Auto", "Cars and trucks."),
            new("1:32 (No. 1 Trains/Aircraft/Cars/54mm Figures)", 32.0, "Railroad/Military", "No. 1 trains, aircraft, cars, and 54mm figures."),
            new("1:35 (Military)", 35.0, "Military", "Standard for military armor (tanks) and figures."),
            new("1:43 (Cars/Trucks)", 43.0, "Auto", "Cars and trucks."),
            new("1:48 (O Scale/Mega size Gundam)", 48.0, "Railroad", "Popular for model trains (O Scale) and some larger aircraft models, armor, and Mega size Gundam."),
            new("1:50 (Architectural / Diecast)", 50.0, "Architecture", "Common for architectural models and diecast construction vehicles."),
            new("1:56 (32 mm scale Warhammer)", 56.0, "Warhammer", "Warhammer models are in this scale."),
            new("1:60 (PG Gundam)", 60.0, "Mecha", "PG Gundam kits are in this scale."),
            new("1:64 (S Scale/Hot Wheels)", 64.0, "Railroad/Diecast", "Matchbox/Hot Wheels cars and S Scale trains."),
            new("1:72 (Aircraft)", 72.0, "Military", "The standard scale for military aircraft, helicopters, and small vehicles."),
            new("1:76.2 (OO Scale)", 76.2, "Railroad", "OO Scale is a scale for model trains and helicopters."),
            new("1:87.1 (HO Scale)", 87.1, "Railroad", "The most popular model railroad scale in the world."),
            new("1:96 (1/8″ Scale Ships)", 96.0, "Ship", "1/8″ scale ships."),
            new("1:100 (MG Gundam)", 100.0, "Mecha", "Standard scale for Master Grade (MG) Gundam kits and architectural models."),
            new("1:125 (15mm Scale)", 125.0, "Military", "15mm scale military models."),
            new("1:144 (HG/RG/Airplanes)", 144.0, "Mecha/Railroad", "High Grade (HG) and Real Grade (RG) Gundams are in this scale, as well as some other Bandai models and airplanes."),
            new("1:160 (N Scale/Epic Scale)", 160.0, "Railroad", "N Scale for US/European trains, with 8.97mm gauge, or 6.5mm or 4.5mm gauge, based on Arnold brand trains. Epic Scale for tabletop wargames (11mm figures)."),
            new("1:200 (Architectural / Ships)", 200.0, "Architecture/Ship", "Architectural site plans and ship models."),
            new("1:220 (Z Scale)", 220.0, "Railroad", "The smallest scale for model trains, 6.5mm gauge, based on Märklin brand trains."),
            new("1:285 (6mm Scale)", 285.0, "Military", "6mm scale military models."),
            new("1:300 (Cruel Seas)", 300.0, "Ship", "Ships from the tabletop game Cruel Seas are in this scale."),
            new("1:350 (Ships)", 350.0, "Ship", "Ships."),
            new("1:500 (Architectural)", 500.0, "Architecture", "Urban planning and large architectural site models."),
            new("1:700 (Ships)", 700.0, "Ship", "Ships."),
            new("1:720 (Ships)", 720.0, "Ship", "Ships."),
            new("1:1200 (Wargame Ships)", 1200.0, "Wargame", "Wargame ships."),
            new("1:2400 (Wargame Ships)", 2400.0, "Wargame", "Wargame ships."),
            new("1:2500 (Science Fiction Ships)", 2500.0, "Space", "Large capital space ships are in this scale."),
        };
    }

    /// <summary>Converts a real-world dimension in millimeters to the model scale in millimeters.</summary>
    /// <param name="realWorldMm">Dimension in real-world millimeters.</param>
    /// <param name="scale">The target scale.</param>
    /// <returns>Model dimension in millimeters.</returns>
    public double ToModelMm(double realWorldMm, ScaleModel scale)
    {
        if (scale.Ratio <= 0) return 0;
        return realWorldMm / scale.Ratio;
    }

    /// <summary>Converts a model dimension (in millimeters) to printer points (72 DPI).</summary>
    /// <param name="modelMm">Dimension in model millimeters.</param>
    /// <returns>Dimension in printer points.</returns>
    public double ToPoints(double modelMm)
    {
        return modelMm * (PointsPerInch / MillimetersPerInch);
    }

    /// <summary>Converts real-world millimeters directly to printer points for the given scale.</summary>
    public double ToScalePoints(double realWorldMm, ScaleModel scale)
    {
        var modelMm = ToModelMm(realWorldMm, scale);
        return ToPoints(modelMm);
    }
}
