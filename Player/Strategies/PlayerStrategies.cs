using Players.Strategies.Implementations;

namespace Players.Strategies
{
    public class PlayerStrategies
    {
        public static RandomPlayerStrategy WithRandomStrategy = new RandomPlayerStrategy();
        public static MemoryPlayerStrategy WithMemoryStrategy = new MemoryPlayerStrategy();
        public static ThoroughPlayerStrategy WithThoroughStrategy = new ThoroughPlayerStrategy();
        public static CheaterPlayerStrategy WithCheaterPlayerStrategy = new CheaterPlayerStrategy();
        public static ThoroughCheaterPlayerStrategy WithThoroughCheaterStrategy = new ThoroughCheaterPlayerStrategy();
    }
}