using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machkin
{
    class BattleHandler
    {
        Player MainCharacter;
        List<Player> SecondaryHero = new List<Player>();

        int GoodForceDamage;
        int MonstersDamage;

        public BattleHandler(Player mainCharacter)
        {
            MainCharacter = mainCharacter;

        }

    }
}
