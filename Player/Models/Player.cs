using Players.Enums;
using Players.Strategies;
using Players.Strategies.Contracts;

namespace Players.Models
{
    public class Player
    {
        
        public Player(PlayerType playerType, string name)
        {
            this.playerType = playerType;
            Name = name;
            PlayerStrategy = PlayerStrategyResolver.playerStrategyResolver[playerType];
        }

        private PlayerType playerType;
        public string Name;
        public int CountOfAttempts = default;
        public IPlayerStrategy PlayerStrategy;
        public bool CanMakeTurn { get; set; }

        public void MakeTurn()
        {
            PlayerStrategy.GetGuess();
        }
    }
}