namespace AmrAmin.DesignPatterns.MementoPattern.EditorExample;
public class EditorState
{
    public string Content { get; }

    public EditorState(string content)
    {
        Content = content;
    }
}
