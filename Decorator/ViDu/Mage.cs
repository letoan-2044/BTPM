using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class Mage : Character
    {
        private string name;

        public Mage(string name)
        {
            this.name = name;
        }

        public override void Display()
        {
            Console.WriteLine($"Mage: {name}");
        }
    }
}
