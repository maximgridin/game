using Players.PlayerStrategies.Contracts;
using Shared.Helpers;

namespace Players.PlayerStrategies.Implementations
{
    public class RandomPlayerStrategy : IPlayerStrategy
    {
        public int GetGuess()
        {
            var guess = GameHelper.GetRandom();
            GameBoard.UsedGuesses.Add(guess);

            return guess;
        }
    }
}