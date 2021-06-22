using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoritmicalTasksAndUT
{
    public class ArrayUniqueValueCountOccur
    {
        public bool IsUniqueIterationValue(int[] arr)
        {
            Dictionary<int, int> dictNums = new Dictionary<int, int>();

            if (arr == null || arr.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (dictNums.ContainsKey(arr[i]))
                {
                    dictNums[arr[i]]++;
                }
                else
                {
                    dictNums[arr[i]] = 1;
                }
            }

            var list = dictNums.Values.Distinct().ToArray();

            return (list.Length == dictNums.Keys.Count());
        }
    }
}
