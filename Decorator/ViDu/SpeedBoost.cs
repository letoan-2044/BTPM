using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class SpeedBoost : SkillDecorator
    {
        public SpeedBoost(Character character) : base(character) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(" + Skill: Speed Boost enabled!");
        }
    }

}
