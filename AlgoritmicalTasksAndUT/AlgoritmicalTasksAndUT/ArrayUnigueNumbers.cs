using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class ArrayUniqueNumbers
    {
        public bool isUniqueValue(int[] Arr)
        {
            Dictionary<int, int> dictNums = new Dictionary<int, int>();

            bool isUnique = true;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (dictNums.ContainsKey(Arr[i]))
                {
                    isUnique = false;

                    break;
                }
                else
                {
                    dictNums.Add(Arr[i], Arr[i]);
                }
            }
            return isUnique;
        }
    }
}
