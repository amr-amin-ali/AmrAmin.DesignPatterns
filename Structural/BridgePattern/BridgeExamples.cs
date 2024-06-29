namespace AmrAmin.DesignPatterns.Structural.BridgePattern;
using No = AmrAmin.DesignPatterns.Structural.BridgePattern.WithoutTheBridgePattern;

public static class BridgeExamples
{
    public static void RunExamples()
    {
        RunRemoteControlsExampleWithoutTheBridgePattern();
        RunRemoteControlsExampleWithTheBridgePattern();
    }
    private static void RunRemoteControlsExampleWithTheBridgePattern()
    {
        UiSkelton.DrawHeader("Use BridgePattern to test the REMOTE CONTROL example.");
        UiSkelton.WriteIndentedText1("Create a remote control that controls a Sony TV");
        IRemoteControl sonyRemote = new AdvancedRemote(new SonyTV());
        sonyRemote.TurnOn();

        UiSkelton.WriteIndentedText1("Create a remote control that controls a LG TV");
        IRemoteControl lgRemote = new AdvancedRemote(new LGTV());
        lgRemote.TurnOn();

        UiSkelton.DrawFooter();

    }
    private static void RunRemoteControlsExampleWithoutTheBridgePattern()
    {
        UiSkelton.DrawHeader(" Testing the REMOTE CONTROL example without the Bridge design pattern.");
        UiSkelton.WriteIndentedText1("Creating SONY remote control");
        var sonyRemote = new No.SonyRemote();
        sonyRemote.TurnOn(); // Outputs: Turning on Sony TV

        UiSkelton.WriteIndentedText1("Creating SAMSUNG remote control");
        var samsungRemote = new No.SamsungRemote();
        samsungRemote.TurnOn(); // Outputs: Turning on Samsung TV

        UiSkelton.WriteIndentedText1("Creating LG remote control");
        var lgRemote = new No.LGRemote();
        lgRemote.TurnOn(); // Outputs: Turning on LG TV

        UiSkelton.DrawFooter();

    }
}
