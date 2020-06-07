using Gridin.TheGame.Players.Models;
using Gridin.TheGame.Players.PlayerStrategies.Contracts;
using Gridin.TheGame.Shared.Constants;
using Gridin.TheGame.Shared.Helpers;

namespace Gridin.TheGame.Players.PlayerStrategies.Implementations
{
    public class ThoroughPlayerStrategy : IPlayerStrategy
    {
        private static int currentGuess = GameConstants.LowerLimit;

        public int MakeGuess(Player player)
        {
            var guess = currentGuess++;

            GameBoard.AddPlayer(guess, player);

            return guess;
        }
    }
}