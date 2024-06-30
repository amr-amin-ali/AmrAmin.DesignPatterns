namespace AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;
public static class AbstractFactoryExamples
{
    public static void RunExamples()
    {
        UiLibrariesExample();
    }
    private static void UiLibrariesExample()
    {
        UiSkelton.DrawHeader("Use AbstractFactoryPattern to test the UiLibraries example.");
        UiSkelton.WriteIndentedText1("Use the Ant-style UI elements");
        var antUIElementFactory = new AntUIElementFactory();
        UiSkelton.WriteIndentedText1($"Create {nameof(UIBuilder)}");
        var uiBuilder = new UIBuilder(antUIElementFactory);
        UiSkelton.WriteIndentedText1($"Build UI using {nameof(UIBuilder)}");
        uiBuilder.BuildUI(); // Renders Ant-style TextBox and Button
        UiSkelton.DrawLineSeparator();
        UiSkelton.DrawLineSeparator();
        UiSkelton.WriteIndentedText1("Use the Material-style UI elements.");
        var materialUIElementFactory = new MaterialUIElementFactory();
        UiSkelton.WriteIndentedText1($"Create {nameof(UIBuilder)}");
        var uiBuilder2 = new UIBuilder(materialUIElementFactory);
        UiSkelton.WriteIndentedText1($"Build UI using {nameof(UIBuilder)}");
        uiBuilder2.BuildUI(); // Renders Material-style TextBox and Button
        UiSkelton.DrawFooter();
    }
}
