namespace AmrAmin.DesignPatterns.Structural.DecoratorPattern;
/// <summary> Concrete Decorator </summary>
public class EncryptedStream : StreamDecorator
{
    public EncryptedStream(IStream stream) : base(stream) { }

    public override void Write(string data)
    {
        string encryptedData = Encrypt(data);
        base.Write(encryptedData);
    }

    private string Encrypt(string data)
    {
        // Implement encryption logic
        char[] chars = ['@', '#', '$', '%', '^', '&', '*', ')', '(', '=', '+', '!', '~', '`'];
        string encryptedData = "";

        Random random = new Random();
        for (int i = 0; i < chars.Length - 1; i++)
        {
            var randomIndex = random.Next(0, chars.Length - 1);
            encryptedData += chars[randomIndex];

        }
        return encryptedData;
    }
}