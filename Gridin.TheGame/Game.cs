using System.Collections.Generic;
using Players.Models;

namespace Gridin.TheGame
{
    public class Game
    {
        public Game(IEnumerable<Player> players)
        {
            this.players = new Queue<Player>(players);
        }

        public Queue<Player> players;
        FruitBasket fruitBasket = FruitBasket.GetFruitBasket();

        public int round = 0;
        
        public void Start()
        {
            while (round> 100)
            {
                foreach (var player in players)
                {
                    if (player.CanMakeTurn)
                    {
                        var guess = player.PlayerStrategy.MakeTurn();
                        GameBoard.UsedNumbers.Add(guess);
                        if (guess == fruitBasket.Weight)
                        {
                                
                        }
                    }
                    
                    
                }
            }
        }
    }
}