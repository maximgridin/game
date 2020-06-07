using Shared.Helpers;

namespace Shared.Models
{
    public class FruitBasket
    {
        private static FruitBasket fruitBasket;

        private FruitBasket() =>
            Weight = GameHelper.GetRandom();

        public static FruitBasket GetFruitBasket() =>
            fruitBasket ?? new FruitBasket();

        public int Weight { get; }
    }
}