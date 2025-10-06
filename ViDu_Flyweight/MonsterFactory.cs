using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ViDu_Flyweight
{
    public class MonsterFactory
    {
        private Dictionary<string, Monster> monsters = new Dictionary<string, Monster>();

        public Monster GetMonster(string key)
        {
            if (!monsters.ContainsKey(key))
            {
                switch (key)
                {
                    case "Goblin":
                        monsters[key] = new Goblin();
                        break;
                    case "Orc":
                        monsters[key] = new Orc();
                        break;
                    case "Troll":
                        monsters[key] = new Troll();
                        break;
                    default:
                        throw new ArgumentException("Unknown monster type: " + key);
                }
            }
            return monsters[key];
        }
    }
}
