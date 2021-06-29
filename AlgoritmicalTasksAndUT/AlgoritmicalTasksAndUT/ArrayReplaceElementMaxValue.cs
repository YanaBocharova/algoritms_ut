using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoritmicalTasksAndUT
{
    public class ArrayReplaceElementMaxValue
    {
        public void SortMAxvaltask3()
        {
            List<int> arr = new List<int> { 12, 18, 2, 4, 6, 2, 1 };
            List<int> output = new List<int>();

            int lenth = arr.Count;

            for (int i = 0; i < lenth - 1; i++)
            {
                arr.RemoveAt(0);
                output.Add(arr.Max());
            }
            output.Add(-1);

            //output.ForEach(item =>
            //{
            //    Console.Write($"{item,3}");
            //});
        }
    }
}
