using System;

namespace AlgoritmicalTasksAndUT
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowResultArrayNumbers();

            Console.Read();
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
