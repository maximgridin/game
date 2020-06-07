using Shared.Helpers;

namespace Gridin.TheGame
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