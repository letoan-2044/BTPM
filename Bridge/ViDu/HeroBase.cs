using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public abstract class HeroBase
    {
        protected SuperPower power;
        protected string name;

        public SuperPower Power
        {
            set { power = value; }
        }

        public HeroBase(string name)
        {
            this.name = name;
        }

        public abstract void UsePower();
    }
}
