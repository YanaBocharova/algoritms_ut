using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class ArraySortByOddEvenValueIndex
    {
        public int[]  SortArrayEvenNumberAtEvenIndex(int[] arr)
        {
            if (arr != null && arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if ((j % 2 == 0 && arr[j] % 2 != 0) || (j % 2 != 0 && arr[j] % 2 == 0))
                        {
                            int tmp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = tmp;
                        }
                    }
                }
                return arr;
            }
            if (arr == null)
            {
                throw new NullReferenceException();
            }
            return arr;
        }
    }
}
