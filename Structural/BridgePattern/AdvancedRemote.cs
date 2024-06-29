namespace AmrAmin.DesignPatterns.Structural.BridgePattern;

public class AdvancedRemote : IRemoteControl
{
    private readonly IDevice _device;

    public AdvancedRemote(IDevice device)
    {
        UiSkelton.WriteIndentedText2("Creating specific device advanced remote...");
        _device = device;
    }

    public void TurnOn()
    {
        UiSkelton.WriteIndentedText2("Using advanced remote to turn device on...");
        _device.TurnOn();
    }
}