using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public abstract class SkillDecorator : Character
    {
        protected Character character;

        public SkillDecorator(Character character)
        {
            this.character = character;
        }

        public override void Display()
        {
            character.Display();
        }
    }
}
