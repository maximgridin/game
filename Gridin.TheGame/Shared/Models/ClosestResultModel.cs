using System.Collections.Generic;
using Gridin.TheGame.Players.Models;

namespace Gridin.TheGame.Shared.Models
{
    public class ClosestResultModel
    {
        public int Guess { get; set; }
        public List<Player> Players { get; set; }
    }
}