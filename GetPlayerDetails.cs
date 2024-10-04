using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class GetPlayerDetails
    {
        public static void GetPlayerName(string name)
        {
            Console.Write($"Player name is: {name}\n");
        }        
        public static void GetPlayerPassword(string pw)
        {
            Console.Write($"Player password is: {pw}\n");

        }
        public static void GetPlayerAge(int age)
        {
            Console.Write($"Player age is: {age}\n");

        }
    }
}
