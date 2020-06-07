using Gridin.TheGame.Constants;
using System;

namespace Shared.Helpers
{
    public static class GameHelper
    {
        public static int GetRandom() => 
            new Random().Next(GameConstants.LowerLimit, GameConstants.LowerLimit + 1);
    }
}