namespace AmrAmin.DesignPatterns.Structural.AdapterPattern;
public static class AdapterExamples
{
    public static void RunExamples()
    {
        RunShapesGroupingExample();
    }
    private static void RunShapesGroupingExample()
    {
        UiSkelton.DrawHeader("Use AdapterPattern to test the IMAGE PROCESSING example.");
        // Usage
        var myVividFilter = new VividFilter();
        myVividFilter.Apply("input_image.jpg");


        var thirdPartyProcessor = new CaramelFilter();
        var imageProcessor = new CaramelFilterAdapter(thirdPartyProcessor);
        imageProcessor.Apply("input_image.jpg");

        UiSkelton.DrawFooter();

    }
}
