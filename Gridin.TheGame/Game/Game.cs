using Gridin.TheGame.Players.Models;
using Gridin.TheGame.Shared.Constants;
using Gridin.TheGame.Shared.Helpers;
using Gridin.TheGame.Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gridin.TheGame.Game
{
    public class Game
    {
        private List<Player> players;
        private static int currentRound;

        public Game(List<Player> players)
        {
            this.players = players;
        }

        public void Start()
        {
            while (true)
            {
                if (!players.Any())
                {
                    Program.Tie();
                }
                for (var index = 0; index < players.Count; index++)
                {
                    var player = players[index];
                    currentRound += 1;
                    player.CountOfAttempts += 1;

                    if (player.CountOfAttempts == GameConstants.MaximumAttempts)
                    {
                        players.Remove(player);

                        continue;
                    }

                    if (player.CanMakeTurn)
                    {
                        var guess = player.MakeGuess();

                        if (guess == FruitBasket.Weight)
                        {
                            Program.Win(player);
                        }
                        else
                        {
                            player.RoundToSkip = GameHelper.CalculateRoundsToSkip(guess);
                        }
                    }
                    else
                    {
                        player.RoundToSkip -= 1;
                    }
                }
            }
        }
    }
}