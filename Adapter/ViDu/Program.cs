using ViDu;

public class Program
{
    public static void Main(string[] args)
    {
        Character unknown = new Character();
        unknown.Display();

        Character warrior = new RichCharacter("Warrior");
        warrior.Display();

        Character mage = new RichCharacter("Mage");
        mage.Display();

        Console.ReadKey();
    }
}