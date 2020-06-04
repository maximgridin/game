using Players.Enums;

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
        public int AttemptCount = 0;
    }
}