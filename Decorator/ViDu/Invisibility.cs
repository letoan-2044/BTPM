using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class Invisibility : SkillDecorator
    {
        public Invisibility(Character character) : base(character) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(" + Skill: Invisibility activated!");
        }
    }
}
