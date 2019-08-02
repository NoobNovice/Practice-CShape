using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7
{
    public interface Action
    {
        int Attack(int def, int spd);
        int Defend(int atk, int spd, bool spcAtk);
        int SpecialAttack(int def);
    }
}
