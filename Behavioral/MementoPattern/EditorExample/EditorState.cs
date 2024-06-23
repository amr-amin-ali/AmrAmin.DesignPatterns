namespace AmrAmin.DesignPatterns.Behavioral.MementoPattern.EditorExample;
public class EditorState
{
    public string Content { get; }

    public EditorState(string content)
    {
        Content = content;
    }
}
