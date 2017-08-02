using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling test");
            var result = ANewHope.count(
                new int[] { 1, 2, 3, 4 },
                new int[] { 4, 3, 2, 1 },
                3);
            var returns = 4;
            Console.WriteLine($"Observed {result} when expecting {returns}");
        }
    }
}