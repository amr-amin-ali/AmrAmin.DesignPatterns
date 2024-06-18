namespace AmrAmin.DesignPatterns.CommandPattern;
using System;

public static class CommandPatternExamples
{
    public static void RunExamples()
    {
        RunLightExample();
    }

    private static void RunLightExample()
    {
        Console.WriteLine(" __________________________________________________________________________________");
        Console.WriteLine("/                                                                                  \\");
        Console.WriteLine("|      Use CommandPattern to test the Light example                                 |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [START]                                        |");
        Console.WriteLine("|                                                                                   |");

        // Usage
        var light = new Light();
        var lightOnCommand = new LightOnCommand(light);
        var remoteControl = new RemoteControl();
        remoteControl.SetCommand(lightOnCommand);
        remoteControl.PressButton(); // Output: Light is on.


        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [END]                                          |");
        Console.WriteLine("\\===================================================================================/");


    }
}
