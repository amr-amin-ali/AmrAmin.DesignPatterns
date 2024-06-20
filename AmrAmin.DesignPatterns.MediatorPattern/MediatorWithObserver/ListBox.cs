namespace AmrAmin.DesignPatterns.MediatorPattern.MediatorWithObserver;

using AmrAmin.DesignPatterns.SharedKernel;




// Concrete Observers
public class ListBox : IObserver
{
    private readonly UIMediator _mediator;
    private List<string> _items;

    public ListBox(UIMediator mediator)
    {
        _mediator = mediator;
        _mediator.Attach(this);
        _items = new List<string>();
        UiSkelton.WriteIndentedText1("Create ListBox UI component");

    }

    public void AddItem(string item)
    {
        UiSkelton.WriteIndentedText2(item + " was added to ListBox.");
        _items.Add(item);
        UiSkelton.WriteIndentedText3("Items in list box:");
        foreach (string i in _items)
        {
            UiSkelton.WriteIndentedText3(i);
        }
    }

    public void FilterItems(string filter)
    {
        UiSkelton.WriteIndentedText2("ListBox items were filtered");
        // Filter items based on the provided text
        this._items = _items.Where(item => filter.Contains(item)).ToList();
        UiSkelton.WriteIndentedText3("Items in the list box:");
        foreach (string item in _items)
        {
            UiSkelton.WriteIndentedText3(item);
        }
    }

    public void ClearSelection()
    {
        UiSkelton.WriteIndentedText2("ListBox items were cleared.");
        _items.Clear();
        // Clear the selection in the ListBox
    }

    public void Update(string action, string data)
    {
        if (action == "TextChanged")
        {
            UiSkelton.WriteIndentedText2("\"TextChanged\" so this ListBox will filter it's items.");
            // Filter items in the listbox
            FilterItems(data);
            UiSkelton.WriteIndentedText2("ListBox items were filtered");
        }
    }
}
