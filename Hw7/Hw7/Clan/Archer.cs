using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7.Clan
{
    class Archer : Stack, Action
    {
        public Archer()
        {
            Atk = 8;
            Spd = 7;
            Def = 3;
        }

        public int Attack(int def, int spd)
        {
            if(this.Spd > def)
            {
                return (this.Atk + 2) - def;
            }
            else
            {
                return this.Atk - def;
            }
        }

        public int Defend(int atk, int spd, bool spcAtk)
        {
            if (spcAtk)
            {
                return atk * 2;
            }
            else
            {
                if(this.Spd > spd + 1)
                {
                    this.Hp -= atk + 5;
                }
                else
                {
                    this.Hp -= atk;
                }
                return 0;
            }
        }

        public int SpecialAttack(int def)
        {
            return (int)((this.Atk * 1.75) - def);
        }
    }
}
