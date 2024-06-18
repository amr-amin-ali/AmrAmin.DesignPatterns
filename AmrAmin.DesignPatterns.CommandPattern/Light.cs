namespace AmrAmin.DesignPatterns.CommandPattern;


/// <summary> Receiver </summary>
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("|            Light is on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("|            Light is off.");
    }
}
