namespace AmrAmin.DesignPatterns.Behavioral.MediatorPattern;

using AmrAmin.DesignPatterns;

public class ListBox
{
    private readonly IMediator _mediator;
    private readonly List<string> _items;

    public ListBox(IMediator mediator)
    {
        _mediator = mediator;
        _items = new List<string>();
    }

    public void AddItem(string item)
    {
        _items.Add(item);
        UiSkelton.WriteIndentedText2(item + "was added to the list.");

    }

    public void FilterItems(string filter)
    {
        UiSkelton.WriteIndentedText2("Items filtered..");
    }

    public void ClearSelection()
    {
        UiSkelton.WriteIndentedText2("Selection cleared.");

    }
}