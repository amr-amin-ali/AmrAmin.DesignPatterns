namespace AmrAmin.DesignPatterns.Structural.AdapterPattern;
public class VividFilter : IFilter
{
    public void Apply(string imagePath)
    {
        UiSkelton.WriteIndentedText2("Applying Vivid filter.");
    }
}
