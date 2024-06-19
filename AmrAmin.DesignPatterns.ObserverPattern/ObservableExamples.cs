namespace AmrAmin.DesignPatterns.ObserverPattern;

using AmrAmin.DesignPatterns.SharedKernel;

public static class ObservableExamples
{
    public static void RunExamples()
    {
        RunPullCommunicationStyleExample();

        RunPushCommunicationStyleExample();

        RunObservableCommunicationStyleExample();

    }

    private static void RunPullCommunicationStyleExample()
    {
        UiSkelton.DrawHeader("Use ObservablePattern to run the PullCommunicationStyle example");
        UiSkelton.DrawFooter();
    }
    private static void RunPushCommunicationStyleExample()
    {
        UiSkelton.DrawHeader("Use ObservablePattern to run the PushCommunicationStyle example");
        UiSkelton.DrawFooter();
    }
    private static void RunObservableCommunicationStyleExample()
    {
        UiSkelton.DrawHeader("Use ObservablePattern to run the ObservableCommunicationStyle example");
        UiSkelton.DrawFooter();
    }
}

