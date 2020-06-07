using Players.PlayerStrategies.Contracts;
using Shared.Constants;
using Shared.Helpers;

namespace Players.PlayerStrategies.Implementations
{
    public class ThoroughCheaterPlayerStrategy : IPlayerStrategy
    {
        private static int currentGuess = GameConstants.LowerLimit;

        public int GetGuess()
        {
            while (!GameBoard.UsedGuesses.Contains(currentGuess))
            {
                currentGuess++;
                GameBoard.UsedGuesses.Add(currentGuess);
            }

            return currentGuess;
        }
    }
}