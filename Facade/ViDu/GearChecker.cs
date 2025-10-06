using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class GearChecker
    {
        public bool HasMinimumGear(Player p)
        {
            Console.WriteLine($"Checking gear for {p.Name}...");
            return p.GearScore >= 400;
        }
    }
}
