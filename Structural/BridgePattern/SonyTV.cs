namespace AmrAmin.DesignPatterns.Structural.BridgePattern;

public class SonyTV : IDevice
{
    public void TurnOn()
    {
        UiSkelton.WriteIndentedText3("SonyTVDevice: Turning on Sony TV");
    }
}