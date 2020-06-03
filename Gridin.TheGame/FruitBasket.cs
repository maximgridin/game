using System;

namespace Gridin.TheGame
{
    public class FruitBasket
    {
        private static FruitBasket fruitBasket;

        private FruitBasket() =>
            Weight = new Random().Next(40, 140);

        public static FruitBasket GetFruitBasket() =>
            fruitBasket ?? new FruitBasket();

        public int Weight { get; }
    }
}