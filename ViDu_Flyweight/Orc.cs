using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu_Flyweight
{
    public class Orc : Monster
    {
        public Orc()
        {
            name = "Orc";
            health = 100;
            damage = 20;
        }

        public override void Summon(int locationX)
        {
            Console.WriteLine($"{name} summoned at X:{locationX} [HP:{health} DMG:{damage}]");
        }
    }
}
