using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class BossFightSystem
    {
        private LevelChecker levelChecker = new LevelChecker();
        private GearChecker gearChecker = new GearChecker();
        private StaminaChecker staminaChecker = new StaminaChecker();

        public bool CanEnterBossFight(Player player)
        {
            Console.WriteLine($"{player.Name} is trying to enter the boss fight...\n");

            bool eligible = true;

            if (!levelChecker.HasRequiredLevel(player))
            {
                Console.WriteLine("❌ Level too low.");
                eligible = false;
            }

            if (!gearChecker.HasMinimumGear(player))
            {
                Console.WriteLine("❌ Gear score too low.");
                eligible = false;
            }

            if (!staminaChecker.HasEnoughStamina(player))
            {
                Console.WriteLine("❌ Not enough stamina.");
                eligible = false;
            }

            return eligible;
        }
    }
}
