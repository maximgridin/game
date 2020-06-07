using System;
using Gridin.TheGame.Players.Models;
using System.Collections.Generic;
using System.Linq;
using Gridin.TheGame.Shared.Models;

namespace Gridin.TheGame.Shared.Helpers
{
    public static class GameBoard
    {
        private static readonly Dictionary<int, List<Player>> UsedGuesses = 
            new Dictionary<int, List<Player>>();

        public static void AddPlayer(int guess, Player player)
        {
            if (UsedGuesses.ContainsKey(guess))
            {
                var playerList = UsedGuesses[guess];
                UsedGuesses.Remove(guess);
                playerList.Add(player);
                UsedGuesses.Add(guess, playerList);
            }
            else
            {
                UsedGuesses.Add(guess, new List<Player> { player });
            }
        }

        public static int CountOfGuesses() => 
            UsedGuesses.Count;

        public static bool Contains(int guess) => 
            UsedGuesses.ContainsKey(guess);

        public static ClosestResultModel GetTiedResult()
        {
            var keys = UsedGuesses.Keys.ToList();

            var closestGuess = keys.OrderBy(v => Math.Abs((long)v - FruitBasket.Weight)).First();

            var players = UsedGuesses[closestGuess];

            return new ClosestResultModel
            {
                Guess = closestGuess,
                Players = players
            };
        }
    }
}