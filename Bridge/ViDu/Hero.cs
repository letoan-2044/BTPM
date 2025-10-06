using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class Hero : HeroBase
    {
        public Hero(string name) : base(name) { }

        public override void UsePower()
        {
            Console.Write($"{name} uses power: ");
            power.Execute();
        }
    }
}
