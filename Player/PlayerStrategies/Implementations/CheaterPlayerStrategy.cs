using System.Linq;
using Players.PlayerStrategies.Contracts;
using Shared.Constants;
using Shared.Helpers;

namespace Players.PlayerStrategies.Implementations
{
    public class CheaterPlayerStrategy : IPlayerStrategy
    {
        public int GetGuess()
        {
            var range = Enumerable.Range(GameConstants.LowerLimit, GameConstants.UpperLimit).Where(i => !GameBoard.UsedGuesses.Contains(i));

            var index = new System.Random().Next(GameConstants.LowerLimit, GameConstants.UpperLimit + 1 - GameBoard.UsedGuesses.Count);

            var guess = range.ElementAt(index);
            GameBoard.UsedGuesses.Add(guess);

            return guess;
        }
    }
}