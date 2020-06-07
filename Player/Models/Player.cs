using Players.Enums;
using Players.PlayerStrategies.Contracts;
using Players.PlayerStrategies.Resolvers;
using Players.Strategies;

namespace Players.Models
{
    public class Player
    {
        public Player(PlayerType playerType, string name)
        {
            this.name = name;
            this.strategy = new PlayerStrategyResolver().Resolve(playerType);
        }

        private readonly IPlayerStrategy strategy;
        private readonly string name;

        public int CountOfAttempts { get; set; }
        public bool CanMakeTurn { get; set; }

        public void MakeTurn()
        {
            strategy.GetGuess();
        }
    }
}
