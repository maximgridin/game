using System;
using Gridin.TheGame.Shared.Constants;
using Gridin.TheGame.Shared.Models;

namespace Gridin.TheGame.Shared.Helpers
{
    public static class GameHelper
    {
        public static int GetRandom()
        {
            var random = new Random().Next(GameConstants.LowerLimit, GameConstants.UpperLimit + 1);

            return random;
        }

        public static int CalculateRoundsToSkip(int playersGuess) => 
            Math.Abs(FruitBasket.Weight - playersGuess) / 10 - 1;
    }
}