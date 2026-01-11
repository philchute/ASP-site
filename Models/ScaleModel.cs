namespace ASP_site.Models;

/// <summary>
/// Represents a hobbyist model scale.
/// </summary>
/// <param name="Name">The display name of the scale (e.g., "1:144 (HG)").</param>
/// <param name="Ratio">The scale ratio (e.g., 144.0). Means 1 unit in model = Ratio units in real world.</param>
/// <param name="Category">The category of the scale (e.g., "Mecha", "Railroad").</param>
/// <param name="Description">A brief description of the scale's common uses.</param>
public record ScaleModel(string Name, double Ratio, string Category, string Description);
