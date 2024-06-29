namespace AmrAmin.DesignPatterns.Structural.BridgePattern.WithoutTheBridgePattern;
using AmrAmin.DesignPatterns.Behavioral.CommandPattern;

public class LGRemote : RemoteControl
{
    public void TurnOn()
    {
        UiSkelton.WriteIndentedText2("Turning on LG TV");
    }
}