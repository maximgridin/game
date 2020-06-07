using Gridin.TheGame.Shared.Helpers;

namespace Gridin.TheGame.Shared.Models
{
    public class FruitBasket
    {
        private static FruitBasket fruitBasket;
        public static readonly int Weight;

        static FruitBasket()
        {
            Weight = GameHelper.GetRandom();
        }

        private FruitBasket()
        {
        }

        public static FruitBasket GetFruitBasket()
        {
            if (fruitBasket == null)
            {
                fruitBasket = new FruitBasket();
            }

            return fruitBasket;
        }
    }
}