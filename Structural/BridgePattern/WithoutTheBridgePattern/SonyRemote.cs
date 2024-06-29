namespace AmrAmin.DesignPatterns.Structural.BridgePattern.WithoutTheBridgePattern;

// Without the Bridge pattern

using AmrAmin.DesignPatterns.Behavioral.CommandPattern;

public class SonyRemote : RemoteControl
{
    public void TurnOn()
    {
        UiSkelton.WriteIndentedText2("Turning on Sony TV");
    }
}
