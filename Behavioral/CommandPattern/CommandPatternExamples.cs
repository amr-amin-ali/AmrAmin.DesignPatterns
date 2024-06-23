namespace AmrAmin.DesignPatterns.Behavioral.CommandPattern;

using AmrAmin.DesignPatterns;

public static class CommandPatternExamples
{
    public static void RunExamples()
    {
        RunLightExample();
    }

    private static void RunLightExample()
    {
        UiSkelton.DrawHeader("Use CommandPattern to test the Light example");



        // Usage
        var light = new Light();
        var lightOnCommand = new LightOnCommand(light);
        var remoteControl = new RemoteControl();
        remoteControl.SetCommand(lightOnCommand);
        remoteControl.PressButton(); // Output: Light is on.


        UiSkelton.DrawFooter();
    }
}
