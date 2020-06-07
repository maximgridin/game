using Gridin.TheGame.Players.Enums;
using Gridin.TheGame.Players.PlayerStrategies.Contracts;
using Gridin.TheGame.Players.PlayerStrategies.Resolvers;

namespace Gridin.TheGame.Players.Models
{
    public class Player
    {
        private readonly IPlayerStrategy strategy;
        public string Name { get; set; }
        public int CountOfAttempts { get; set; }
        public bool CanMakeTurn => RoundToSkip <= 0;
        public int RoundToSkip { get; set; }

        public Player(PlayerType playerType, string name)
        {
            Name = name;
            strategy = new PlayerStrategyResolver().Resolve(playerType);
        }

        public int MakeGuess() =>
            strategy.MakeGuess(this);
    }
}
