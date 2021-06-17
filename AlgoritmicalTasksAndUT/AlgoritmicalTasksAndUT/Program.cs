using System;

namespace AlgoritmicalTasksAndUT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");




            int[] arr = { 1, 2, 2, 6, 6, 6, 6, 7, 10};
            int[] arr2=null;

            ArrayNumbers array = new ArrayNumbers();

            int foundNumber=array.ReturnNumber(arr);

            Console.WriteLine($"found integer= {foundNumber}");




            Console.Read();
        }
    }
}
