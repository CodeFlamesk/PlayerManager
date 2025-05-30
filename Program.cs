using System;

namespace PlayerManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager manager = new PlayerManager();

            manager.CreatePlayer(new Player(1, 101, "Dima", 10, false));
            manager.CreatePlayer(new Player(2, 102, "Nazar", 20, false));
            manager.CreatePlayer(new Player(3, 103, "Ivan", 15, false));

            Console.WriteLine("\nAll players");
            manager.PrintAllPlayers();

            Console.WriteLine("\n Ban player with ID 2");
            manager.BanPlayer(2);
            
            Console.WriteLine("\n Unban player with ID 2");
            manager.UnbanPlayer(2);

            Console.WriteLine("\nAll players after ban");
            manager.PrintAllPlayers();

            Console.WriteLine("\n Remove player with ID 1");
            manager.RemovePlayer(1);

            Console.WriteLine("\n All players after remove");
            manager.PrintAllPlayers();
        }
    }
}