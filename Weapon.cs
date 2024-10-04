using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class Weapon
    {
        public int WeaponDmg { get; set; }

        public Weapon(int weaponDmg)
        {
            WeaponDmg = weaponDmg;
        }

        public void DealDmg(Monster monster) 
        {
            monster.HP -= WeaponDmg <= 0 ? monster.HP = 0 : monster.HP -= WeaponDmg;
        }
    }
}
