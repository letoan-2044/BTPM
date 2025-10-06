using DPM225468_NguyenHuuTai_Proxy;

public class Program
{
    public static void Main(string[] args)
    {
        // Create proxy and request a service
        Proxy proxy = new Proxy();
        proxy.Request();
        // Wait for user
        Console.ReadKey();
    }
}