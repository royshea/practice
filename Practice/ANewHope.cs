using System.Linq;

namespace Practice
{
    public class ANewHope
    {
        public static int count(int[] firstWeek, int[] lastWeek, int washDays)
        {
            // Basic properties
            var weekLength = firstWeek.Length;
            var maxMove = weekLength - washDays;

            // Iterate through first week tracking index for each key
            var deltas = new int[weekLength];
            for (var i = 0; i < weekLength; i++)
            {
                var shirtId = firstWeek[i];
                deltas[shirtId-1] = i;
            }

            // Iterate through second week tracking the spread from that key in first week
            for (var i = 0; i < weekLength; i++)
            {
                var shirtId = lastWeek[i];
                deltas[shirtId-1] -= i;
            }

            // Find largest spread
            var largestMoveNeeded = deltas.Max();

            // Use this spread to determine how long it takes to shift
            //
            // Extra math in this implements ceil of largestMoveNeeded / maxMove in int math.
            var numWeeks = (largestMoveNeeded + maxMove - 1) / maxMove;

            // Account for starting point
            var initialWeek = 1;

            return numWeeks + initialWeek;
        }
    }
}
