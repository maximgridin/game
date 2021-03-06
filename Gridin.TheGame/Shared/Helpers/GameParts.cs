﻿using Gridin.TheGame.Players.Enums;
using Gridin.TheGame.Players.Models;
using System;
using System.Collections.Generic;

namespace Gridin.TheGame.Shared.Helpers
{
    public class GameParts
    {
        public static int ResolvePlayerCount()
        {
            Console.WriteLine("Please set the amount of participating players minimum 2, maximum 8");
            var consoleKey = Console.ReadLine();
            Int32.TryParse(consoleKey, out var result);

            return result;
        }

        public static List<Player> ResolvePlayers(int count)
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

                Int32.TryParse(consoleKey, out var playerType);
                
                players.Add(new Player((PlayerType)playerType, playerName));
                ++player;
            }

            return players;
        }

        public static void Win(Player player)
        {
            Console.WriteLine($"The winner: {player.Name}. With total amount of attempts: {player.CountOfAttempts}. ");
            Console.WriteLine("Press any key to exit. ");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static void Tie()
        {
            var result = GameBoard.GetTiedResult();

            Console.WriteLine("The tie. Closest player: ");

            foreach (var player in result.Players)
            {
                Console.WriteLine($"The player with name {player.Name} and guess: {result.Guess}");
            }

            Console.WriteLine("Press any key to exit. ");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}