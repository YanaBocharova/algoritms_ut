using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class ReplaceElementArrayMaxValue
    {
        public List<int> ReplaceElementMaxValue(List<int> arr)
        {
            List<int> output = new List<int>();

            int lenth = arr.Count;

            for (int i = 0; i < lenth - 1; i++)
            {
                arr.RemoveAt(0);

                output.Add(arr.Max());
            }

            output.Add(-1);

            return output;
        }
    }
}
