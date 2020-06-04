using Players.Enums;
using Players.Models;
using System;
using System.Collections.Generic;

namespace Gridin.TheGame
{
    internal class Program
    {
        
        public static void Main()
        {
            var playerCount = ResolvePlayerCount();
            var players = ResolvePlayers(playerCount);

            Console.ReadLine();
        }

        private static int ResolvePlayerCount()
        {
            Console.WriteLine("Please set the amount of participating players minimum 2, maximum 8");
            var consoleKey = Console.ReadLine();
            int.TryParse(consoleKey, out var result);

            return result;
        }

        private static IEnumerable<Player> ResolvePlayers(int count)
        {
            var players = new List<Player>();

            var player = 1;
            Console.WriteLine();
            Console.WriteLine("Random Type: 1");
            Console.WriteLine("Memory Type: 2");
            Console.WriteLine("Thorough Type: 3");
            Console.WriteLine("Cheater Type: 4");
            Console.WriteLine("ThoroughCheater Type: 5");
            Console.WriteLine();
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter the name of {player} player ");
                var playerName = Console.ReadLine();

                Console.WriteLine("Enter player type ");
                var consoleKey = Console.ReadLine();

                int.TryParse(consoleKey, out var playerType);
                
                players.Add(new Player((PlayerType)playerType, playerName));
                ++player;
            }

            return players;
        }
    }
}
