using Players.PlayerStrategies.Contracts;
using Shared.Constants;
using Shared.Helpers;

namespace Players.PlayerStrategies.Implementations
{
    public class ThoroughPlayerStrategy : IPlayerStrategy
    {
        private static int currentGuess = GameConstants.LowerLimit;

        public int GetGuess()
        {
            var guess = currentGuess++;

            GameBoard.UsedGuesses.Add(guess);

            return guess;
        }
    }
}