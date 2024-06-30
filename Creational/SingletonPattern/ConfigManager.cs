namespace AmrAmin.DesignPatterns.Creational.SingletonPattern;

public sealed class ConfigManager
{
    private static readonly ConfigManager _instance = new ConfigManager();
    private static readonly Dictionary<string, string> _settings = new Dictionary<string, string>();
    private ConfigManager()
    {
        UiSkelton.WriteIndentedText2($"Creaing inatance of {nameof(ConfigManager)}");
    }

    public static ConfigManager GetInstance()
    {
        return _instance;
    }

    public void AddSeeting(string key, string value)
    {
        UiSkelton.WriteIndentedText2($"Setting ({key}, {value}) was added.");
        _settings.Add(key, value);
    }

    public string GetSetting(string key)
    {
        UiSkelton.WriteIndentedText2($"Value \"{_settings[key]}\" was returned.");
        return _settings[key];
    }
}
