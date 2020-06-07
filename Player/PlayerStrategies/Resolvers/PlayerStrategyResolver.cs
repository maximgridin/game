using Players.Enums;
using System.Collections.Generic;
using Players.PlayerStrategies.Contracts;
using Players.PlayerStrategies.Implementations;

namespace Players.PlayerStrategies.Resolvers
{
    public class PlayerStrategyResolver
    {
        private readonly Dictionary<PlayerType, IPlayerStrategy> possibleStrategies =
            new Dictionary<PlayerType, IPlayerStrategy>
            {
                {PlayerType.Random, new RandomPlayerStrategy()},
                {PlayerType.Memory, new MemoryPlayerStrategy()},
                {PlayerType.Thorough, new ThoroughPlayerStrategy()},
                {PlayerType.Cheater, new CheaterPlayerStrategy()},
                {PlayerType.ThoroughCheater, new ThoroughCheaterPlayerStrategy()},
            };

        public IPlayerStrategy Resolve(PlayerType playerType) =>
            possibleStrategies[playerType];
    }
}