using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoritmicalTasksAndUT
{
    public class SelfDividingNumbersList
    {
        public List<int> SeachSelfDivisibleNumbers(int left, int right)
        {
            var listAnswrers = new List<int>();

            for (int i = left; i <= right; i++)
            {
                if (!(i.ToString().Contains('0')))
                {
                    if (i.ToString().ToCharArray().All(num => i % int.Parse(num.ToString())== 0))

                    listAnswrers.Add(i);
                }
            }

            return listAnswrers;
        }
    }
}
