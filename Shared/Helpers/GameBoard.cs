using System.Collections.Generic;

namespace Shared.Helpers
{
    public static class GameBoard
    {
        public static Dictionary<int, object> Used
        public static HashSet<int> UsedGuesses { get; } = new HashSet<int>();
    }
}