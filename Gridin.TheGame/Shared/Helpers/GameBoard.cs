using Gridin.TheGame.Players.Models;
using System.Collections.Generic;

namespace Gridin.TheGame.Shared.Helpers
{
    public static class GameBoard
    {
        private static Dictionary<int, List<Player>> usedGuesses = new Dictionary<int, List<Player>>();

        public static void AddPlayer(int guess, Player player)
        {
            if (usedGuesses.ContainsKey(guess))
            {
                var playerList = usedGuesses[guess];
                usedGuesses.Remove(guess);
                playerList.Add(player);
                usedGuesses.Add(guess, playerList);
            }
            else
            {
                usedGuesses.Add(guess, new List<Player> { player });
            }
        }

        public static int UsedGuesses()
        {
            return usedGuesses.Count;
        }

        public static bool Contains(int guess) => 
            usedGuesses.ContainsKey(guess);
    }
}