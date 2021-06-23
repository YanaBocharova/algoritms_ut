using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class ArrayStringByCondition
    {
        private string case1 = "FizzBuzz";

        private string case2 = "Fizz";

        private string case3 = "Buzz";

        public List<string> CreateArrayStringByConditionInputArray(int[] arr)
        {
            if (arr == null)
            {
                throw new Exception();
            }

            List<string> listAnswers = new List<string>();

            if (arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 3 == 0 && arr[i] % 5 == 0)
                    {
                        listAnswers.Add(case1);
                    }
                    if (arr[i] % 3 == 0 && arr[i] % 5 != 0)
                    {
                        listAnswers.Add(case2);
                    }
                    if (arr[i] % 5 == 0 && arr[i] % 3 != 0)
                    {
                        listAnswers.Add(case3);
                    }
                    if ((arr[i] % 3 != 0 && arr[i] % 5 != 0))
                    {
                        listAnswers.Add(arr[i].ToString());
                    }
                }
            }

            return listAnswers;
        }
    }
}
