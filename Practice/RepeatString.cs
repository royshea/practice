using System.Linq;

namespace Practice
{
    public class RepeatString
    {
        public static int minimalModify(string s)
        {
            string firstHalf = s.Substring(0, s.Length / 2);
            string secondHalf = s.Substring(s.Length / 2);

            int?[,] cache = new int?[firstHalf.Length+1, secondHalf.Length+1];
            int edits = EditDistance(firstHalf, secondHalf, cache);
            return edits;
        }

        private static int EditDistance(string firstHalf, string secondHalf, int?[,] cache)
        {
            int? cacheEdits = cache[firstHalf.Length, secondHalf.Length];
            if (cacheEdits != null)
            {
                return (int)cacheEdits;
            }

            int edits;
            if (firstHalf.Length == 0)
            {
                edits = secondHalf.Length;
            }
            else if (secondHalf.Length == 0)
            {
                edits = firstHalf.Length;
            }
            else if (firstHalf[firstHalf.Length - 1] == secondHalf[secondHalf.Length - 1])
            {
                edits = EditDistance(
                    firstHalf.Substring(0, firstHalf.Length - 1),
                    secondHalf.Substring(0, secondHalf.Length - 1),
                    cache
                    );
            }
            else
            {
                int addLetter = 1 + EditDistance(
                    firstHalf.Substring(0, firstHalf.Length - 1),
                    secondHalf.Substring(0, secondHalf.Length),
                    cache
                    );
                int removeLetter = 1 + EditDistance(
                    firstHalf.Substring(0, firstHalf.Length),
                    secondHalf.Substring(0, secondHalf.Length - 1),
                    cache
                    );
                int changeLetter = 1 + EditDistance(
                    firstHalf.Substring(0, firstHalf.Length - 1),
                    secondHalf.Substring(0, secondHalf.Length - 1),
                    cache
                    );
                int[] options = new int[] { addLetter, removeLetter, changeLetter };
                edits = options.Min();
            }

            cache[firstHalf.Length, secondHalf.Length] = edits;
            return edits;
        }
    }
}
