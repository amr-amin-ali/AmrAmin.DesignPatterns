namespace AmrAmin.DesignPatterns.Behavioral.CommandPattern;
/// <summary> Concrete command </summary>
public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}
