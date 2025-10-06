using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class Character
    {
        protected int health;
        protected int mana;
        protected string weapon;

        public virtual void Display()
        {
            Console.WriteLine("\nCharacter: Unknown ------");
        }
    }
}
