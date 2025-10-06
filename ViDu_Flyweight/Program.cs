using System.Threading;
using ViDu_Flyweight;

public class Program
{
    public static void Main(string[] args)
    {
        // Câu lệnh triệu hồi quái vật
        string summons = "GoblinOrcGoblinTrollOrcGoblin";

        // Chia thành từng tên riêng
        List<string> monsterList = new List<string> {
                "Goblin", "Orc", "Goblin", "Troll", "Orc", "Goblin"
            };

        MonsterFactory factory = new MonsterFactory();

        // Trạng thái ngoài (extrinsic): vị trí xuất hiện
        int position = 0;

        foreach (string monsterName in monsterList)
        {
            position += 10;

            Monster monster = factory.GetMonster(monsterName);
            monster.Summon(position);
        }

        Console.ReadKey();
    }
}