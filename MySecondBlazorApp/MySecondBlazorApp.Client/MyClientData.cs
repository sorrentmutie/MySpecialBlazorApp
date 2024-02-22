using Libreria;

namespace MySecondBlazorApp.Client;

public class MyClientData : IMyData
{
    public string GetSomeData()
    {
        return "client string data";
    }
}

public class MyClientDataSpecial : IMyDataSpecial
{
    public string GetSomeData()
    {
        return "client special  string data";
    }
}
