using Gridin.TheGame.Constants;
using Gridin.TheGame.Helpers;
using System;
using System.Linq;

namespace Gridin.TheGame
{
    internal class Program
    {
        
        public static void Main()
        {
            var playerCount = ResolvePlayerCount();
            
            Console.ReadLine();

            //var randomPlayer = new Player(PlayerStrategies.WithRandomStrategy, "John");
            //var memoryPlayer = new Player(PlayerStrategies.WithMemoryStrategy, "Jimmy");
            //var thoroughPlayer = new Player(PlayerStrategies.WithThoroughStrategy, "Jane");
            //var cheaterPlayer = new Player(PlayerStrategies.WithCheaterPlayerStrategy, "James");
            //var thoroughCheaterPlayer = new Player(PlayerStrategies.WithThoroughCheaterStrategy, "Jason");
        }

        private static int ResolvePlayerCount()
        {
            Console.WriteLine("Please set the amount of participating players minimum 2, maximum 8");

            while (true)
            {
                var consoleKey = Console.ReadKey().Key;

                if (GameConstants.AllowedKeys.Contains(consoleKey))
                {
                    Console.WriteLine();
                    return  (int) consoleKey;
                }
                else
                {
                    ConsoleHelper.ClearCurrentConsoleLine();
                }
            }
        }
    }
}
