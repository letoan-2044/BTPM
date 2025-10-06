using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class LevelChecker
    {
        public bool HasRequiredLevel(Player p)
        {
            Console.WriteLine($"Checking level for {p.Name}...");
            return p.Level >= 20;
        }
    }
}
