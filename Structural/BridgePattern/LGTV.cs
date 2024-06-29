namespace AmrAmin.DesignPatterns.Structural.BridgePattern;

public class LGTV : IDevice
{
    public void TurnOn()
    {
        UiSkelton.WriteIndentedText3("LGTVDevice: Turning on LG TV");
    }
}