using Gridin.TheGame.Constants;
using Players.Strategies.Contracts;
using Shared.Helpers;

namespace Players.Strategies.Implementations
{
    public class ThoroughCheaterPlayerStrategy : IPlayerStrategy
    {
        private static int CurrentGuess = GameConstants.LowerLimit;

        public int GetGuess()
        {
            while (!GameBoard.UsedGuesses.Contains(CurrentGuess))
            {
                CurrentGuess++;
                GameBoard.UsedGuesses.Add(CurrentGuess);
            }

            return CurrentGuess;
        }
    }
}