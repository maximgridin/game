using Gridin.TheGame.Constants;
using Players.Strategies.Contracts;
using Shared.Helpers;

namespace Players.Strategies.Implementations
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