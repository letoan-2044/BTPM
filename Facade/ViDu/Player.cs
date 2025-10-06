using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class Player
    {
        public string Name { get; }
        public int Level { get; }
        public int GearScore { get; }
        public int Stamina { get; }

        public Player(string name, int level, int gearScore, int stamina)
        {
            Name = name;
            Level = level;
            GearScore = gearScore;
            Stamina = stamina;
        }
    }
}
