namespace AmrAmin.DesignPatterns.Behavioral.StatePattern.PhotoshopExample;
public class Canvas
{
    private ITool _currentTool;

    public void SetTool(ITool tool)
    {
        _currentTool = tool;
    }

    public void MouseDown()
    {
        _currentTool.MouseDown();
    }
    public void MouseUp()
    {
        _currentTool.MouseUp();
    }
}
