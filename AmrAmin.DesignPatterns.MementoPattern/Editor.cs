namespace AmrAmin.DesignPatterns.MementoPattern;
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
        this.Content = content;
    }
    public string GetContent()
    {
        return Content;
    }
}
