using System;

namespace AlgoritmicalTasksAndUT
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowResultArrayNumbers();

            ShowResultArrayUniqueNumbers();

            Console.Read();
        }
        private static void ShowResultArrayUniqueNumbers()
        {
            int[] arr = { 1, 12, 32,2, 22, 0, 33 };

            ArrayUniqueNumbers array = new ArrayUniqueNumbers();

            bool isUnique = array.isUniqueValue(arr);

            Console.WriteLine($"array contains all values == {isUnique}");

        }
        private static void ShowResultArrayNumbers()
        {
            int[] arr = { 1, 2, 2, 6, 6, 6, 6, 7, 10 };

            ArrayNumbers array = new ArrayNumbers();

            int foundNumber = array.ReturnNumber(arr);

            Console.WriteLine($"found integer= {foundNumber}");

        }
    }
}
