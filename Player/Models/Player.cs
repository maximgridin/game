using Players.Strategies.Contracts;

namespace Players.Models
{
    public class Player
    {
        public Player(IPlayerStrategy gameStrategy, string name)
        {
            this.gameStrategy = gameStrategy;
            Name = name;
        }

        private IPlayerStrategy gameStrategy;
        public string Name;
        public int AttemptCount = 0;
    }
}