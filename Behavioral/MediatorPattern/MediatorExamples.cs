namespace AmrAmin.DesignPatterns.Behavioral.MediatorPattern;

using AmrAmin.DesignPatterns;

using MWO = MediatorWithObserver;

public static class MediatorExamples
{
    public static void RunExamples()
    {
        RunPureMediatorExample();
        RunMediatorWithObserverExample();
    }
    public static void RunPureMediatorExample()
    {
        UiSkelton.DrawHeader("Use MediatorPattern to test the pure MEDIATOR example");
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





        UiSkelton.DrawFooter();
    }

    public static void RunMediatorWithObserverExample()
    {
        UiSkelton.DrawHeader("Use MediatorPattern to test the pure MEDIATOR with OBSERVER example");



        // Create the mediator
        MediatorWithObserver.UIMediator mediator = new MWO.UIMediator();

        // Create the UI components
        var textBox = new MWO.TextBox(mediator);
        var button = new MWO.Button(mediator);
        var listBox = new MWO.ListBox(mediator);
        var navbar = new MWO.Navbar(mediator);

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

        UiSkelton.DrawFooter();
    }
}
