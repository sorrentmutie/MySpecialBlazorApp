using Libreria;

namespace MySecondBlazorApp.Services;

public class ServerData : IMyData
{
    public string GetSomeData()
    {
        return "server string data";
    }
}

public class ServerDataSpecial : IMyDataSpecial
{
    public string GetSomeData()
    {
        return "server special string data";
    }
}
