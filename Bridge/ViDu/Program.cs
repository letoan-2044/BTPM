
using ViDu;

// Client
public class Program
{
    public static void Main(string[] args)
    {
        // Create a superhero
        HeroBase hero = new Hero("Captain Shadow");

        // Assign a power
        hero.Power = new InvisibilityPower();
        hero.UsePower();

        // Switch to another power
        hero.Power = new FlyPower();
        hero.UsePower();

        // Switch to laser
        hero.Power = new LaserPower();
        hero.UsePower();

        Console.ReadKey();
    }
}