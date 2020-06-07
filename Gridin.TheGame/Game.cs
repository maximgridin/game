using System.Collections.Generic;
using Players.Models;
using Shared.Models;

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
                        //var guess = player.MakeTurn();
                        
                        //if (guess == fruitBasket.Weight)
                        //{
                                
                        //}
                    }
                    
                    
                }
            }
        }
    }
}