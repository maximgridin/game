using Players.Strategies.Contracts;
using Shared.Helpers;

namespace Players.Strategies.Implementations
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