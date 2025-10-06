using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class RichCharacter : Character
    {
        private string type;
        private LegacyCharacterStats stats;

        public RichCharacter(string type)
        {
            this.type = type;
        }

        public override void Display()
        {
            stats = new LegacyCharacterStats();

            health = stats.GetHealth(type);
            mana = stats.GetMana(type);
            weapon = stats.GetWeapon(type);

            Console.WriteLine($"\nCharacter: {type} ------");
            Console.WriteLine($" Health: {health}");
            Console.WriteLine($" Mana  : {mana}");
            Console.WriteLine($" Weapon: {weapon}");
        }
    }
}
