namespace MonsterGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Monster goblin = new Monster(50);
            Player dado = new Player("Dadorap", "dado1988", 36);
            Weapon sword = new Weapon(20);
            //GetPlayerDetails.GetPlayerName(dado.PlayerName);
            //GetPlayerDetails.GetPlayerAge(dado.Age);
            //GetPlayerDetails.GetPlayerPassword(dado.Password);


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"hp left of the Goblin: {goblin.HP}");
                sword.DealDmg(goblin);
            }       
                goblin.DmgTaken();

            

            Console.ReadKey();
            
        }
    }
}
