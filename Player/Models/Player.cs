using Players.Enums;
using Players.Strategies.Contracts;

namespace Players.Models
{
    public class Player
    {
        public Player(PlayerType playerType, string name)
        {
            this.playerType = playerType;
            Name = name;
        }

        private PlayerType playerType;
        public string Name;
        public int CountOfAttempts = default;
        public IPlayerStrategy PlayerStrategy;
        public bool CanMakeTurn { get; set; }
    }
}