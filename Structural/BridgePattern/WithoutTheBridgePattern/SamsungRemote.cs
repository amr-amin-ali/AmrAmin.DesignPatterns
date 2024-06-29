namespace AmrAmin.DesignPatterns.Structural.BridgePattern.WithoutTheBridgePattern;
using AmrAmin.DesignPatterns.Behavioral.CommandPattern;

public class SamsungRemote : RemoteControl
{
    public void TurnOn()
    {
        UiSkelton.WriteIndentedText2("Turning on Samsung TV");
    }
}