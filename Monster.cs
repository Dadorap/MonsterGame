using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class Monster
    {
        public int HP { get; set; }
        public Monster(int hp)
        {
            if (hp <= 0)
            {
                HP = 0;
            }
            else
            {

                HP = hp;
            }
        }

        public void DmgTaken()
        {
            if (HP == 0)
            {
                Console.WriteLine("Dead!");
            }
            else
            {
                return;
            }
        }
    }
}
