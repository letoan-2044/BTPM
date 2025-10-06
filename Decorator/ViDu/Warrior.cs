using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class Warrior : Character
    {
        private string name;

        public Warrior(string name)
        {
            this.name = name;
        }

        public override void Display()
        {
            Console.WriteLine($"Warrior: {name}");
        }
    }
}
