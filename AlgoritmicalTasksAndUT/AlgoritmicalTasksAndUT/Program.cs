using System;

namespace AlgoritmicalTasksAndUT
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowResultArrayNumbers();

            ShowResulIterationValueArray();

            Console.Read();
        }
        private static void ShowResulIterationValueArray()
        {
            ArrayUniqueValueCountOccur ArrayNumTestObj = new ArrayUniqueValueCountOccur();

            int[] arr = { 1, 1, 2, 3, 3, 3, 3 };
            // act
            var result = ArrayNumTestObj.IsUniqueIterationValue(arr);

            Console.WriteLine($"iteration unique values = {result}");
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
