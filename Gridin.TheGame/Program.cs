using Gridin.TheGame.Shared.Helpers;

namespace Gridin.TheGame
{
    internal class Program
    {
        public static void Main()
        {
            var playerCount = GameParts.ResolvePlayerCount();
            var players = GameParts.ResolvePlayers(playerCount);
            var game = new Game.Game(players);
            game.Start();
        }
    }
}
