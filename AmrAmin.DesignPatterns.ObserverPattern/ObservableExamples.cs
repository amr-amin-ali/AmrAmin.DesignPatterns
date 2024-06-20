namespace AmrAmin.DesignPatterns.ObserverPattern;

using AmrAmin.DesignPatterns.ObserverPattern.ObservableCommunicationStyle;
using AmrAmin.DesignPatterns.ObserverPattern.ObserverStockExample;
using AmrAmin.DesignPatterns.SharedKernel;

using PullStyle = AmrAmin.DesignPatterns.ObserverPattern.PullCommunicationStyle;
using PushStyle = AmrAmin.DesignPatterns.ObserverPattern.PushCommunicationStyle;

public static class ObservableExamples
{
    public static void RunExamples()
    {
        RunPullCommunicationStyleExample();

        RunPushCommunicationStyleExample();

        RunObservableCommunicationStyleExample();

        RunObserverStockMarketExample();

    }

    private static void RunObserverStockMarketExample()
    {
        UiSkelton.DrawHeader("Use ObservablePattern to run the Observer STOCK MARKET example");
        var stockMarket = new StockMarket();

        var investor1 = new IndividualInvestor("Amr Amin");
        var investor2 = new InstitutionalInvestor("Amin Ali");
        UiSkelton.WriteIndentedText1("Amr Amin is subscribing to the stock market subject.");
        UiSkelton.DrawLineSeparator();
        stockMarket.AttachInvestor(investor1);

        UiSkelton.WriteIndentedText1("Amin Ali is subscribing to the stock market subject.");
        UiSkelton.DrawLineSeparator();
        stockMarket.AttachInvestor(investor2);

        UiSkelton.WriteIndentedText1("Add \"AAPL\" to stock with price: 120.50");
        UiSkelton.DrawLineSeparator();
        stockMarket.AddStock("AAPL", 120.50);

        UiSkelton.WriteIndentedText1("Add \"MSFT\" to stock with price: 250.00");
        UiSkelton.DrawLineSeparator();
        stockMarket.AddStock("MSFT", 250.00);

        UiSkelton.WriteIndentedText1("Remove \"AAPL\" from stock");
        UiSkelton.DrawLineSeparator();
        stockMarket.RemoveStock("AAPL");

        UiSkelton.DrawFooter();
    }
    private static void RunPullCommunicationStyleExample()
    {
        UiSkelton.DrawHeader("Use ObservablePattern to run the Pull Communication Style example");
        // Create a Subject and some Observers
        var subject = new PullStyle.Subject<int>();
        var observer1 = new PullStyle.ConcreteObserver<int>("Observer 1", subject);
        var observer2 = new PullStyle.ConcreteObserver<int>("Observer 2", subject);

        // Attach the observers to the subject
        subject.Attach(observer1);
        subject.Attach(observer2);

        // Change the state of the subject and notify the observers
        subject.SetState(42);
        subject.SetState(24);

        UiSkelton.DrawFooter();
    }
    private static void RunPushCommunicationStyleExample()
    {
        UiSkelton.DrawHeader("Use ObservablePattern to run the Push Communication Style example");
        // Create a Subject and some Observers
        var subject = new PushStyle.Subject<int>();
        var observer1 = new PushStyle.ConcreteObserver<int>();
        var observer2 = new PushStyle.ConcreteObserver<int>();

        // Attach the observers to the subject
        subject.Attach(observer1);
        subject.Attach(observer2);

        // Change the state of the subject and notify the observers
        subject.SetState(42);
        subject.SetState(24);

        UiSkelton.DrawFooter();
    }
    private static void RunObservableCommunicationStyleExample()
    {
        UiSkelton.DrawHeader("Use ObservablePattern to run the Observable Communication Style example");
        // Create a Subject and some Observers
        var subject = new Subject<int>();
        var observer1 = new ConcreteObserver<int>("Observer 1");
        var observer2 = new ConcreteObserver<int>("Observer 2");

        // Attach the observers to the subject
        subject.Attach(observer1);
        subject.Attach(observer2);

        // Change the state of the subject and notify the observers
        subject.SetState(42);
        subject.SetState(24);
        UiSkelton.DrawFooter();
    }
}

