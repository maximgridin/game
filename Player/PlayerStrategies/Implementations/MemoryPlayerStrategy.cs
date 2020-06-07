using System.Collections.Generic;
using System.Linq;
using Players.PlayerStrategies.Contracts;
using Shared.Constants;
using Shared.Helpers;

namespace Players.PlayerStrategies.Implementations
{
    public class MemoryPlayerStrategy : IPlayerStrategy
    {
        private readonly HashSet<int> memory = new HashSet<int>();

        public int GetGuess()
        {
            var range = 
                Enumerable.Range(GameConstants.LowerLimit, GameConstants.UpperLimit).Where(i => !memory.Contains(i));

            var index = new System.Random().Next(GameConstants.LowerLimit, GameConstants.UpperLimit + 1 - memory.Count);
            var guess = range.ElementAt(index);

            memory.Add(guess);
            GameBoard.UsedGuesses.Add(guess);

            return guess;
        }
    }
}