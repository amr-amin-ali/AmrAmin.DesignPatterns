namespace AmrAmin.DesignPatterns.MementoPattern.EditorExample;
using System.Collections.Generic;

public class History
{
    private readonly Stack<EditorState> _history = new Stack<EditorState>();
    public void Push(EditorState state)
    {
        _history.Push(state);
    }
    public EditorState Pop()
    {
        return _history.Pop();
    }
}

