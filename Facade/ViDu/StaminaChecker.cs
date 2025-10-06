using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class StaminaChecker
    {
        public bool HasEnoughStamina(Player p)
        {
            Console.WriteLine($"Checking stamina for {p.Name}...");
            return p.Stamina >= 50;
        }
    }
}
