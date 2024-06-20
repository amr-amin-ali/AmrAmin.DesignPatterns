# Mediator Design Pattern in C#

The Mediator Design Pattern is a behavioral design pattern that promotes loose coupling between objects by encapsulating their communication within a mediator object. It aims to provide a centralized communication mechanism between different objects in a system. Instead of objects communicating directly with each other, they communicate indirectly through a central mediator object. This pattern is particularly useful when you have a complex system with multiple objects that need to communicate with each other, but you want to avoid direct dependencies between them. This pattern helps to decouple the objects, making the system more maintainable, flexible, and easier to understand.

## Implementing the Mediator Design Pattern

In this example, we'll consider a simple user interface with four different objects: `TextBox`, `Button`, `ListBox`, and `Navbar`. These objects need to communicate with each other, and we'll use the Mediator Design Pattern to facilitate their interactions.

```csharp
// Mediator interface
public interface IMediator
{
    void Notify(object sender, string action);
}

// Concrete Mediator
public class UIMediator : IMediator
{
    private TextBox _textBox;
    private Button _button;
    private ListBox _listBox;
    private Navbar _navbar;

    public void RegisterTextBox(TextBox textBox)
    {
        _textBox = textBox;
    }

    public void RegisterButton(Button button)
    {
        _button = button;
    }

    public void RegisterListBox(ListBox listBox)
    {
        _listBox = listBox;
    }

    public void RegisterNavbar(Navbar navbar)
    {
        _navbar = navbar;
    }

    public void Notify(object sender, string action)
    {
        if (sender == _textBox && action == "TextChanged")
        {
            UiSkelton.WriteIndentedText2("TextBox notification was fired.");

            _button.Enable();
            _listBox.FilterItems(_textBox.Text);
            _navbar.UpdateTitle(_textBox.Text);
        }
        else if (sender == _button && action == "Clicked")
        {
            UiSkelton.WriteIndentedText2("Button notification was fired.");

            _textBox.Clear();
            _listBox.ClearSelection();
            _navbar.ResetTitle();
        }
    }
}


public class Button
{
    private readonly IMediator _mediator;
    private bool _isEnabled;

    public Button(IMediator mediator)
    {
        _mediator = mediator;
        _isEnabled = false;
    }

    public void Enable()
    {
        _isEnabled = true;
        UiSkelton.WriteIndentedText2("Button is enabled.");
    }

    public void Disable()
    {
        _isEnabled = false;
        UiSkelton.WriteIndentedText2("Button is disabled.");

    }

    public void Click()
    {
        if (_isEnabled)
        {
            _mediator.Notify(this, "Clicked");
        }
    }
}

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

public class Navbar
{
    private readonly IMediator _mediator;
    private string _title;

    public Navbar(IMediator mediator)
    {
        _mediator = mediator;
        _title = "Default Title";
    }

    public void UpdateTitle(string newTitle)
    {
        _title = newTitle;
        UiSkelton.WriteIndentedText2("Navbar title was updated.");

    }

    public void ResetTitle()
    {
        _title = "Default Title";
        UiSkelton.WriteIndentedText2("Navbar title was resetted.");
    }
}

public class TextBox
{
    private readonly IMediator _mediator;
    public string Text { get; set; }

    public TextBox(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void TextChanged()
    {
        _mediator.Notify(this, "TextChanged");
    }
    public void Clear()
    {
        Text = string.Empty;
        _mediator.Notify(this, "Text Cleared");
    }
}



// Usage example
// Usage example
var mediator = new UIMediator();
var textBox = new TextBox(mediator);
var button = new Button(mediator);
var listBox = new ListBox(mediator);
var navbar = new Navbar(mediator);

UiSkelton.WriteIndentedText1("Register textBox to mediator.");
mediator.RegisterTextBox(textBox);
UiSkelton.WriteIndentedText1("Register button to mediator.");
mediator.RegisterButton(button);
UiSkelton.WriteIndentedText1("Register listBox to mediator.");
mediator.RegisterListBox(listBox);
UiSkelton.WriteIndentedText1("Register navbar to mediator.");
mediator.RegisterNavbar(navbar);

UiSkelton.WriteIndentedText1("Write text to \"Search term\" in the textbox.");
textBox.Text = "Search term";
UiSkelton.WriteIndentedText1("Call \"textBox.TextChanged();\"");
textBox.TextChanged(); // This will enable the button, filter the listbox, and update the navbar title
UiSkelton.WriteIndentedText1("Click the button");
button.Click(); // This will clear the textbox, clear the listbox selection, and reset the navbar title

```

In this example, the `UIMediator` class is the concrete mediator that coordinates the interactions between the different UI components (`TextBox`, `Button`, `ListBox`, and `Navbar`). Each component registers itself with the mediator, and when an event occurs in one component, the mediator is responsible for notifying the other components and coordinating their actions.

## Implementing the Mediator Pattern with the Observer Pattern

The Mediator Pattern can also be implemented using the Observer Pattern. In this approach, the mediator acts as the subject, and the components act as the observers.

```csharp
// Subject interface
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string action, string data);
}

// Concrete Subject
public class UIMediator : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }
    
public class UIMediator : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string action, string? data)
    {
        foreach (var observer in _observers)
        {
            observer.Update(action, data);
        }
    }

    public void TextBoxTextChanged(string newText)
    {
        Notify("TextChanged", newText);
    }

    public void ButtonClicked()
    {
        Notify("Clicked", null);
    }
}

// Observer interface
public interface IObserver
{
    void Update(string action, string data);
}

// Concrete Observers
// Concrete Observers
public class TextBox : IObserver
{
    private readonly UIMediator _mediator;
    public string Text { get; set; }

    public TextBox(UIMediator mediator)
    {
        UiSkelton.WriteIndentedText1("Create TextBox UI component");
        _mediator = mediator;
        _mediator.Attach(this);
    }

    public void TextChanged()
    {
        _mediator.TextBoxTextChanged(Text);
    }

    public void Update(string action, string data)
    {
        if (action == "TextChanged")
        {
            // Enable button, filter listbox, update navbar title
        }
    }
}

public class Navbar : IObserver
{
    private readonly UIMediator _mediator;
    private string _title;

    public Navbar(UIMediator mediator)
    {
        UiSkelton.WriteIndentedText1("Create Navbar UI component");
        _mediator = mediator;
        _mediator.Attach(this);
        _title = "Default Title";
        UiSkelton.WriteIndentedText2("Navbar title: " + _title);
    }

    public void UpdateTitle(string newTitle)
    {
        _title = newTitle;
        UiSkelton.WriteIndentedText3("Navbar title: " + newTitle);
        // Update the title in the Navbar
    }

    public void ResetTitle()
    {
        _title = "Default Title";
        UiSkelton.WriteIndentedText2("Navbar was resetted.");
        UiSkelton.WriteIndentedText3("Navbar title: " + _title);
        // Reset the title in the Navbar
    }

    public void Update(string action, string data)
    {
        if (action == "TextChanged")
        {
            // Update the navbar title
            UiSkelton.WriteIndentedText2("\"TextChanged\" so navbar title updated.");
            UpdateTitle(data);

        }
        else if (action == "Clicked")
        {
            // Reset the navbar title
            UiSkelton.WriteIndentedText2("\"ButtonClicked\" so navbar title resetted.");
            _title = "";

        }
    }
}

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

public class Button : IObserver
{
    private readonly UIMediator _mediator;
    private bool _isEnabled;

    public Button(UIMediator mediator)
    {
        _mediator = mediator;
        _mediator.Attach(this);
        _isEnabled = false;
        UiSkelton.WriteIndentedText1("Create Button UI component");

    }

    public void Enable()
    {
        _isEnabled = true;
    }

    public void Disable()
    {
        _isEnabled = false;
    }

    public void Click()
    {
        if (_isEnabled)
        {
            _mediator.ButtonClicked();
        }
    }

    public void Update(string action, string data)
    {
        if (action == "Clicked")
        {
            UiSkelton.WriteIndentedText2("Button was clicked.");
            UiSkelton.WriteIndentedText3(" Clear textbox.");
            UiSkelton.WriteIndentedText3(" Clear listbox selection.");
            UiSkelton.WriteIndentedText3(" reset navbar title.");

            // Clear textbox, clear listbox selection, reset navbar title
            _mediator.ButtonClicked();
        }
    }
}

// Create the mediator
MWO.UIMediator mediator = new MWO.UIMediator();

// Create the UI components
MWO.TextBox textBox = new MWO.TextBox(mediator);
MWO.Button button = new MWO.Button(mediator);
MWO.ListBox listBox = new MWO.ListBox(mediator);
MWO.Navbar navbar = new MWO.Navbar(mediator);

// Add items to the ListBox
UiSkelton.WriteIndentedText1("Add \"AAAAAAAAAAAAAAAAA\" to the ListBox");
listBox.AddItem("AAAAAAAAAAAAAAAAA");
UiSkelton.WriteIndentedText1("Add \"BBBBBBBBBBBBBBBBB\" to the ListBox");
listBox.AddItem("BBBBBBBBBBBBBBBBB");
UiSkelton.WriteIndentedText1("Add \"CCCCCCCCCCCCCCCCC\" to the ListBox");
listBox.AddItem("CCCCCCCCCCCCCCCCC");

// Interact with the UI components
UiSkelton.WriteIndentedText1("Write \"AAAAAAAAAAAAAAAAA\" to the TextBox");
textBox.Text = "AAAAAAAAAAAAAAAAA";
UiSkelton.WriteIndentedText1("Call the \"textBox.TextChanged();\"");
textBox.TextChanged();

// The TextChanged event is raised, and the mediator notifies the observers
// The TextBox, Button, ListBox, and Navbar components update their state accordingly
// For example:
// - The Button is enabled
// - The ListBox items are filtered
// - The Navbar title is updated

// User clicks the Button
UiSkelton.WriteIndentedText1("Click the button.");
button.Click();

// The Clicked event is raised, and the mediator notifies the observers
// The TextBox, ListBox, and Navbar components update their state accordingly
// For example:
// - The TextBox is cleared
// - The ListBox selection is cleared
// - The Navbar title is reset
```

In this version, the `UIMediator` class acts as the subject, and the UI components (`TextBox`, `Button`, `ListBox`, and `Navbar`) act as the observers. The mediator maintains a list of observers and notifies them when an event occurs. The observers then update their state accordingly.

## Benefits of the Observer Pattern

Implementing the Mediator Pattern with the Observer Pattern offers several benefits:

1. **Loose Coupling**: The components are loosely coupled, as they only depend on the mediator and not on each other directly. This makes the system more flexible and easier to maintain. Using the Observer pattern further enhances this decoupling by removing the direct dependency between the Mediator and the Colleagues.
2. **Scalability**: Adding or removing components is easier, as the mediator can simply attach or detach the observers as needed.
3. **Flexibility**: The Observer pattern allows for dynamic registration and deregistration of Colleagues, making the system more flexible and adaptable to changes.
4. **Testability**: The separation of concerns and the ability to easily register and unregister Colleagues make the system more testable, as each component can be tested in isolation.
5. **Reusability**: The Observer pattern provides a generic and reusable mechanism for implementing the communication between the Mediator and the Colleagues, which can be easily applied to other Mediator-based scenarios. Also the components can be reused in other parts of the application or in different applications, as they don't rely on specific implementation details of the mediator.

## When to Use the Mediator Pattern

The Mediator Pattern is useful when you have a complex system with multiple objects that need to communicate with each other, and you want to avoid direct dependencies between them. It's particularly useful in the following scenarios:

- **User Interfaces**: As shown in the example, the Mediator Pattern can be used to manage the interactions between different UI components.
- **Workflow Systems**: The Mediator Pattern can be used to coordinate the actions of different components in a workflow system.
- **Event-driven Systems**: The Mediator Pattern can be used to manage the communication between event producers and event consumers.

> **You can use it when**:
> - You have a system with multiple objects that need to communicate with each other, and you want to avoid direct coupling between them.
> - You have a set of related objects that need to communicate, but you don't want to expose their implementation details to each other.
> - You want to centralize the communication logic in a single component, making the system more maintainable and easier to understand.

## When Not to Use the Mediator Pattern


The Mediator Design Pattern might not be the best choice when:

- The communication between objects is simple and can be easily handled without a central mediator.
- The system is small and the benefits of using the Mediator pattern do not outweigh the added complexity.
- The communication patterns are complex and the Mediator becomes a bottleneck, reducing the overall performance of the system.

## Best Practices
1. **Keep the Mediator Simple**: The Mediator should only be responsible for coordinating the communication between Colleagues, and should not contain complex business logic.

2. **Avoid God Mediators**: Ensure that the Mediator does not become a "God object" that tries to handle everything, as this can lead to a violation of the Single Responsibility Principle.

3. **Prefer Composition over Inheritance**: When implementing the Mediator pattern, prefer composition (using a Mediator reference in Colleagues) over inheritance (Colleagues inheriting from the Mediator).

4. **Use the Observer Pattern**: As demonstrated in the previous section, using the Observer pattern to implement the Mediator pattern can provide additional benefits in terms of flexibility, reusability, and testability.

5. **Consider Alternative Patterns**: Depending on the specific requirements of your system, other design patterns, such as the Facade or the Chain of Responsibility, may be more suitable than the Mediator pattern.

## Conclusion
The Mediator Design Pattern is a powerful tool for managing the communication between objects in a system. By introducing a central Mediator, you can decouple the Colleagues, making the system more maintainable, flexible, and easier to understand. When combined with the Observer pattern, the Mediator pattern can further enhance these benefits and provide a more robust and reusable solution.