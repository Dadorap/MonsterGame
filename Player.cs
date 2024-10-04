using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class Player
    {
      
        public string PlayerName { get; set; }

        public string Password { get; set; }
        public int Age { get; set; }

        public Player(string playerName, string password, int age)
        {
            PlayerName = playerName;
            if (password.Length < 8 || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Password must be atleast 8 characters");
            }
            else
            {
            Password = password;
            }
            Age = age;
        }
    }
}
