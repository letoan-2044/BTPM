using System.Numerics;
using ViDu;

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo facade
        BossFightSystem bossFight = new BossFightSystem();

        // Người chơi muốn tham gia trận đấu boss
        Player player = new Player("Aeris", level: 25, gearScore: 420, stamina: 80);

        bool canEnter = bossFight.CanEnterBossFight(player);

        Console.WriteLine("\n" + player.Name +
            (canEnter ? " is allowed to enter the boss fight!" : " is NOT allowed to enter."));

        Console.ReadKey();
    }
}