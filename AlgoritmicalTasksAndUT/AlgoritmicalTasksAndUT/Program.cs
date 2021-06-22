using System;

namespace AlgoritmicalTasksAndUT
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowResultArrayNumbers();

            ShowResulIterationValueArray();

            ShowResulItSortEvenNumberAtEvenIndex();

            Console.Read();
        }
        private static void ShowResulItSortEvenNumberAtEvenIndex()
        {
            ArraySortByOddEvenValueIndex ArrayNumTestObj = new ArraySortByOddEvenValueIndex();

            int[] arr = { 3, 3, 22, 3, 22};
           
            var sortArr= ArrayNumTestObj.SortArrayEvenNumberAtEvenIndex(arr);

            foreach (var item in sortArr)
            {
                Console.Write($"{item,5}");
            }

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
