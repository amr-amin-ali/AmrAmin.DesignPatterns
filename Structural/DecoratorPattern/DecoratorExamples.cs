namespace AmrAmin.DesignPatterns.Structural.DecoratorPattern;
public static class DecoratorExamples
{
    public static void RunExamples()
    {
        RunStreamExample();
    }
    private static void RunStreamExample()
    {
        UiSkelton.DrawHeader("Use DecoratorPattern to test the STREAM example.");
        UiSkelton.WriteIndentedText1("Writing \"Hello, world!\" using Stream.");
        IStream stream = new Stream();
        stream.Write("Hello, world!");

        UiSkelton.WriteIndentedText1("Writing \"Hello, world!\" using EncryptedStream.");
        IStream encryptedStream = new EncryptedStream(stream);
        encryptedStream.Write("Sensitive data");

        UiSkelton.WriteIndentedText1("Writing \"Hello, world!\" using CompressedStream.");
        IStream compressedStream = new CompressedStream(stream);
        compressedStream.Write("Large data payload");


        UiSkelton.DrawFooter();

    }
}
