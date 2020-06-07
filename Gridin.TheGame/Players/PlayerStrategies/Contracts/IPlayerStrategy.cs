using Gridin.TheGame.Players.Models;

namespace Gridin.TheGame.Players.PlayerStrategies.Contracts
{
    public interface IPlayerStrategy
    {
        int MakeGuess(Player player);
    }
}