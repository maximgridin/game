using Gridin.TheGame.Players.Models;
using Gridin.TheGame.Players.PlayerStrategies.Contracts;
using Gridin.TheGame.Shared.Helpers;

namespace Gridin.TheGame.Players.PlayerStrategies.Implementations
{
    public class RandomPlayerStrategy : IPlayerStrategy
    {
        public int MakeGuess(Player player)
        {
            var guess = GameHelper.GetRandom();
            GameBoard.AddPlayer(guess, player);

            return guess;
        }
    }
}