using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoritmicalTasksAndUT
{
    public class ArrayNumbers
    {
        public int ReturnNumber(int[]  arr)
        {
            Dictionary<int, int> dictNums = new Dictionary<int, int>();

            int foundValue = -1;

            if (arr != null && arr.Length!=0)
            {
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
                int maxNumber = dictNums.Values.Max();

                foreach(var key in dictNums.Keys)
                {
                    if (dictNums[key] == maxNumber)
                    {
                        foundValue = key;

                        break;
                    }
                }
            }

            return foundValue;
        }
    }
}
