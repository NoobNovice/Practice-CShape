using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hw7
{
    public abstract class Stack
    {
        private int allstack = 18;
        private int atk = 6;
        private int def = 6;
        private int spd = 6;
        private int hp = 30;

        public int Atk
        {
            get
            {
                return atk;
            }
            set
            {
                if(value + def + spd <= allstack)
                {
                    atk = value;
                }
            }
        }

        public int Def
        {
            get
            {
                return def;
            }
            set
            {
                if (value + atk + spd <= allstack)
                {
                    def = value;
                }
            }
        }

        public int Spd
        {
            get
            {
                return spd;
            }
            set
            {
                if(value + atk + def <= allstack)
                {
                    spd = value;
                }
            }
        }

        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                if(value <= 50)
                {
                    hp = value;
                }
            }
        }
    }
}
