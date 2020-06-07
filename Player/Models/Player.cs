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
            this.Name = name;
            this.strategy = new PlayerStrategyResolver().Resolve(playerType);
        }

        private readonly IPlayerStrategy strategy;
        public string Name { get; set; }

        public int CountOfAttempts { get; set; }

        public bool CanMakeTurn
        {
            get
            {
                return 
            }
            set
            {

            }
        }

        public void MakeTurn()
        {
            strategy.GetGuess();
        }
    }
}
