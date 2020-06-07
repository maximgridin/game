using Shared.Models;
using System;
using Shared.Constants;

namespace Shared.Helpers
{
    public static class GameHelper
    {
        public static int GetRandom() => 
            new Random().Next(GameConstants.LowerLimit, GameConstants.LowerLimit + 1);

        public static int CalculateRoundsToSkip(int playersGuess) => 
            Math.Abs(FruitBasket.GetFruitBasket().Weight - playersGuess) / 10 - 1;
    }
}