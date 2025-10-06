using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu_Flyweight
{
    public class Troll : Monster
    {
        public Troll()
        {
            name = "Troll";
            health = 150;
            damage = 30;
        }

        public override void Summon(int locationX)
        {
            Console.WriteLine($"{name} summoned at X:{locationX} [HP:{health} DMG:{damage}]");
        }
    }
}
