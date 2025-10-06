using DPM225477_LeHuuToan_VD_Abstract_Factory;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập hệ điều hành (windows/mac): ");
        string os = Console.ReadLine()?.ToLower();

        GUIFactory factory;

        if (os == "windows")
        {
            factory = new WindowsFactory();
        }
        else if (os == "mac")
        {
            factory = new MacFactory();
        }
        else
        {
            Console.WriteLine("Hệ điều hành không được hỗ trợ.");
            return;
        }

        Application app = new Application(factory);
        app.RenderUI();
    }
}
