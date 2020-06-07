using System.Linq;
using Gridin.TheGame.Players.Models;
using Gridin.TheGame.Players.PlayerStrategies.Contracts;
using Gridin.TheGame.Shared.Constants;
using Gridin.TheGame.Shared.Helpers;

namespace Gridin.TheGame.Players.PlayerStrategies.Implementations
{
    public class CheaterPlayerStrategy : IPlayerStrategy
    {
        public int MakeGuess(Player player)
        {
            var range = Enumerable.Range(GameConstants.LowerLimit, GameConstants.UpperLimit).Where(i => !GameBoard.Contains(i));

            var index = new System.Random().Next(GameConstants.LowerLimit, GameConstants.UpperLimit + 1 - GameBoard.UsedGuesses());

            var guess = range.ElementAt(index);
            GameBoard.AddPlayer(guess, player);

            return guess;
        }
    }
}