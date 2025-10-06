using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu_Flyweight
{
    public abstract class Monster
    {
        protected string name;
        protected int health;
        protected int damage;

        public abstract void Summon(int locationX);
    }
}
