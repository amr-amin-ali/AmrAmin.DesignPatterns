namespace AmrAmin.DesignPatterns.Structural.AdapterPattern;

// Adaptee (third-party library)
public class CaramelFilter
{
    public void ApplyFilters(string inputPath, string outputPath)
    {
        UiSkelton.WriteIndentedText3($"Applying caramel filter to image.");
    }
}
