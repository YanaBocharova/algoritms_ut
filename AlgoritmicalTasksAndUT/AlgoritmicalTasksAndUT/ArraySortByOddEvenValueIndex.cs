using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class ArraySortByOddEvenValueIndex
    {
        public int[]  SortArrayEvenNumberAtEvenIndex(int[] arr)
        {
            if (arr == null)
            {
                throw new NullReferenceException();
            }

            Stack<int> evenNum = new Stack<int>();

            Stack<int> oddNum = new Stack<int>();

            if ( arr.Length != 0 )
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if( arr[i] % 2 == 0)
                    {
                        evenNum.Push(arr[i]);
                    }

                    if (arr[i] % 2 != 0)
                    {
                        oddNum.Push(arr[i]);
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if( i % 2 == 0 && evenNum.Count !=0)
                {
                    arr[i] = evenNum.Pop();
                }

                if (i % 2 != 0 && oddNum.Count != 0)
                {
                    arr[i] = oddNum.Pop();
                }
            }

            return arr;
        }
    }
}
