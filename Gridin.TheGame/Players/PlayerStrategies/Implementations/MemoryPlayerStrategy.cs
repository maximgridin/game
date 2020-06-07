using System.Collections.Generic;
using System.Linq;
using Gridin.TheGame.Players.Models;
using Gridin.TheGame.Players.PlayerStrategies.Contracts;
using Gridin.TheGame.Shared.Constants;
using Gridin.TheGame.Shared.Helpers;

namespace Gridin.TheGame.Players.PlayerStrategies.Implementations
{
    public class MemoryPlayerStrategy : IPlayerStrategy
    {
        private readonly HashSet<int> memory = new HashSet<int>();

        public int MakeGuess(Player player)
        {
            var range = 
                Enumerable.Range(GameConstants.LowerLimit, GameConstants.UpperLimit).Where(i => !memory.Contains(i));

            var index = new System.Random().Next(GameConstants.LowerLimit, GameConstants.UpperLimit + 1 - memory.Count);
            var guess = range.ElementAt(index);

            memory.Add(guess);
            GameBoard.AddPlayer(guess, player);

            return guess;
        }
    }
}