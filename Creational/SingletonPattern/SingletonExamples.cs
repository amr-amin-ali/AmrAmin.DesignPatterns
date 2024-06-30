namespace AmrAmin.DesignPatterns.Creational.SingletonPattern;
public static class SingletonExamples
{
    public static void RunExamples()
    {
        RunConfigManagerExample();
    }
    private static void RunConfigManagerExample()
    {
        UiSkelton.DrawHeader("Use SingletonPattern to test the ConfigManager example.");
        UiSkelton.WriteIndentedText1($"Getting instance of {nameof(ConfigManager)} as singleton1");
        ConfigManager singleton1 = ConfigManager.GetInstance();
        UiSkelton.WriteIndentedText1($"Add setting (\"mode\", \"dark\") to singleton1");
        singleton1.AddSeeting("mode", "dark");
        UiSkelton.WriteIndentedText1($"Add setting (\"color\", \"black\") to singleton1");
        singleton1.AddSeeting("color", "black");

        UiSkelton.WriteIndentedText1($"Getting the setting \"mode\" from singleton1");
        singleton1.GetSetting("mode");

        UiSkelton.WriteIndentedText1($"Getting instance of {nameof(ConfigManager)} as singleton2");
        ConfigManager singleton2 = ConfigManager.GetInstance();
        UiSkelton.WriteIndentedText1($"Getting the setting \"color\" from  singleton2");
        singleton2.GetSetting("color");


        UiSkelton.DrawFooter();
    }
}
