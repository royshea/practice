using System.Linq;

namespace Practice
{
    public class ANewHope
    {
        public static int count(int[] firstWeek, int[] lastWeek, int washDays)
        {
            // Basic properties
            var weekLength = firstWeek.Length;

            // Iterate through first week tracking index for each key then
            // the second week to track how far forward a shirt has shifted.
            //
            // Note: Could optimize this by combinging the two for loops, but
            // I (Roy) think that this code is clearer with two separate loops.
            var deltas = new int[weekLength];
            for (var i = 0; i < weekLength; i++)
            {
                var shirtId = firstWeek[i];
                deltas[shirtId-1] = i;
            }
            for (var i = 0; i < weekLength; i++)
            {
                var shirtId = lastWeek[i];
                deltas[shirtId-1] -= i;
            }

            // Find largest delta and use it to determine how many weeks are
            // needed to acheive that spread.
            //
            // Note: Extra terms when calculating num weeks are used to
            // provide the equivalent of ceil(largestMoveNeeded / maxMove)
            // directly on integers.
            var largestMoveNeeded = deltas.Max();
            var maxMove = weekLength - washDays;
            var numWeeks = (largestMoveNeeded + maxMove - 1) / maxMove;

            // Account for starting week.
            var initialWeek = 1;
            return numWeeks + initialWeek;
        }
    }
}
