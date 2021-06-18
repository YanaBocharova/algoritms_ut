using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class ArrayUniqueNumbers
    {
        public bool IsUniqueValue(int[] arr)
        {
            Dictionary<int, int> dictNums = new Dictionary<int, int>();

            bool isUnique = true;

            if (arr == null || arr.Length == 0)
            {
                isUnique = false;
            }
            else
            { 
                for (int i = 0; i < arr.Length; i++)
                {
                    if (dictNums.ContainsKey(arr[i]))
                    {
                        isUnique = false;
                        break;
                    }
                    else
                    {
                        dictNums.Add(arr[i], arr[i]);
                    }
                }
            }
            return isUnique;
        }
    }
}
