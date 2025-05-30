using System;
using System.Collections.Generic;

namespace PlayerManagerApp
{
    public class PlayerManager
    {
        private readonly List<Player> players = new List<Player>();

        public Player CreatePlayer(Player player)
        {
            players.Add(player);
            return player;
        }

       public void BanPlayer(int idPlayer)
        {
            Player? player = players.FirstOrDefault(p => p.IdPlayer == idPlayer);
            if (player != null)
            {
                player.Flag = true;
                Console.WriteLine($"Player with ID {idPlayer} has been banned");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }
       
        public void UnbanPlayer(int idPlayer)
        {
            Player? player = players.FirstOrDefault(p => p.IdPlayer == idPlayer);
            if (player != null)
            {
                player.Flag = false;
                Console.WriteLine($"Player with ID {idPlayer} has been unbanned");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }
        public void RemovePlayer(int idPlayer)
        {
            Player? toRemove = players.FirstOrDefault(p => p.IdPlayer == idPlayer);

            if (toRemove != null)
            {
                players.Remove(toRemove);
                Console.WriteLine($"Player with ID {idPlayer} removed");
            }
            else
            {
                Console.WriteLine("Player not found");
            }
        }
        
        public void PrintAllPlayers()
        {
            if (players.Count == 0)
            {
                Console.WriteLine("No players in the list");
                return;
            }

            foreach (var player in players)
            {
                Console.WriteLine(player);
            }
        }

        public Player? GetPlayerById(int id)
        {
            return players.FirstOrDefault(p => p.IdPlayer == id);
        }
    }
}