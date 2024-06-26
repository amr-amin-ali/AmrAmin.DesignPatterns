namespace AmrAmin.DesignPatterns.Structural.AdapterPattern;


// Adapter
public class CaramelFilterAdapter : IFilter
{
    private readonly CaramelFilter _thirdPartyProcessor;

    public CaramelFilterAdapter(CaramelFilter thirdPartyProcessor)
    {
        _thirdPartyProcessor = thirdPartyProcessor;
    }

    public void Apply(string imagePath)
    {
        UiSkelton.WriteIndentedText2("Applying catamel filter using the adapter.");
        string outputPath = $"{imagePath.Substring(0, imagePath.LastIndexOf('.'))}_processed.jpg";
        _thirdPartyProcessor.ApplyFilters(imagePath, outputPath);
    }
}
