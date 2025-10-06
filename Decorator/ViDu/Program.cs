using System.Threading;
using ViDu;

public class Program
{
    public static void Main(string[] args)
    {
        // Nhân vật cơ bản
        Character warrior = new Warrior("Thoran");
        warrior.Display();

        // Trang bị năng lực tàng hình
        Console.WriteLine("\n> Adding Invisibility...");
        Character invisibleWarrior = new Invisibility(warrior);
        invisibleWarrior.Display();

        // Trang bị thêm tăng tốc
        Console.WriteLine("\n> Adding Speed Boost...");
        Character speedInvisibleWarrior = new SpeedBoost(invisibleWarrior);
        speedInvisibleWarrior.Display();

        Console.ReadKey();
    }
}