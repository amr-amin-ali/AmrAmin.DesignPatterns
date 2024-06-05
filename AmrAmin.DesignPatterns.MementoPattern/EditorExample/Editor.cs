namespace AmrAmin.DesignPatterns.MementoPattern.EditorExample;
public class Editor
{
    public string Content { get; private set; }
    public EditorState CreateState()
    {
        return new EditorState(Content);
    }
    public void Restore(EditorState state)
    {
        Content = state.Content;
    }
    public void SetContent(string content)
    {
        Content = content;
    }
    public string GetContent()
    {
        return Content;
    }
}
