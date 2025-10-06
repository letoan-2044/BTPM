using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class Heal : SkillDecorator
    {
        public Heal(Character character) : base(character) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(" + Skill: Healing over time...");
        }
    }
}
