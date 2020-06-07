using Players.Enums;
using Players.Strategies.Contracts;
using System.Collections.Generic;

namespace Players.Strategies
{
    public class PlayerStrategyResolver
    {
        public static Dictionary<PlayerType, IPlayerStrategy> playerStrategyResolver =
            new Dictionary<PlayerType, IPlayerStrategy>
            {
                {PlayerType.Random, PlayerStrategies.WithRandomStrategy},
                {PlayerType.Memory, PlayerStrategies.WithMemoryStrategy},
                {PlayerType.Thorough, PlayerStrategies.WithThoroughStrategy},
                {PlayerType.Cheater, PlayerStrategies.WithCheaterPlayerStrategy},
                {PlayerType.ThoroughCheater, PlayerStrategies.WithThoroughCheaterStrategy},
            };
    }
}