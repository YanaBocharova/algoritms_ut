using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoritmicalTasksAndUT
{
    public class LuckyIntengerInArray
    {
        public int SeachLuckyInterger(int[] arr)
        {
            if (arr != null && arr.Length != 0)
            {
                Dictionary<int, int> dictNums = new Dictionary<int, int>();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (dictNums.Keys.Contains(arr[i]))
                    {
                        dictNums[arr[i]]++;
                    }
                    else
                    {
                        dictNums.Add(arr[i], 1);
                    }
                }

                var listLuckyNyms = dictNums.Keys.Where(item => item == dictNums[item]).ToList();

                if (listLuckyNyms.Count != 0)
                {
                    return listLuckyNyms.Max();
                }

                return -1;

            }

            return -1;
        }
    }
}
