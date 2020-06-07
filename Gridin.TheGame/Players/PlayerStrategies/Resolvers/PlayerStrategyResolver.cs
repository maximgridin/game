using System.Collections.Generic;
using Gridin.TheGame.Players.Enums;
using Gridin.TheGame.Players.PlayerStrategies.Contracts;
using Gridin.TheGame.Players.PlayerStrategies.Implementations;

namespace Gridin.TheGame.Players.PlayerStrategies.Resolvers
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