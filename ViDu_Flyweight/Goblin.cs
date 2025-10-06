using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu_Flyweight
{
    public class Goblin : Monster
    {
        public Goblin()
        {
            name = "Goblin";
            health = 50;
            damage = 10;
        }

        public override void Summon(int locationX)
        {
            Console.WriteLine($"{name} summoned at X:{locationX} [HP:{health} DMG:{damage}]");
        }
    }
}
