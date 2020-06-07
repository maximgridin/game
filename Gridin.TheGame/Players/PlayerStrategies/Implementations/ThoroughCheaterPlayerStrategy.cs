using Gridin.TheGame.Players.Models;
using Gridin.TheGame.Players.PlayerStrategies.Contracts;
using Gridin.TheGame.Shared.Constants;
using Gridin.TheGame.Shared.Helpers;

namespace Gridin.TheGame.Players.PlayerStrategies.Implementations
{
    public class ThoroughCheaterPlayerStrategy : IPlayerStrategy
    {
        private static int currentGuess = GameConstants.LowerLimit;

        public int MakeGuess(Player player)
        {
            while (!GameBoard.Contains(currentGuess))
            {
                currentGuess++;
                GameBoard.AddPlayer(currentGuess, player);
            }

            return currentGuess;
        }
    }
}