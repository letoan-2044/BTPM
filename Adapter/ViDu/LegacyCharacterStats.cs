using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class LegacyCharacterStats
    {
        public int GetHealth(string type)
        {
            switch (type.ToLower())
            {
                case "warrior": return 150;
                case "mage": return 80;
                default: return 100;
            }
        }

        public int GetMana(string type)
        {
            switch (type.ToLower())
            {
                case "warrior": return 20;
                case "mage": return 200;
                default: return 50;
            }
        }

        public string GetWeapon(string type)
        {
            switch (type.ToLower())
            {
                case "warrior": return "Sword";
                case "mage": return "Staff";
                default: return "None";
            }
        }
    }
}
