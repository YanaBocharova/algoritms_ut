using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoritmicalTasksAndUT
{
    public class SelfDividingNumbersList
    {
        public List<int> SeachSelfDivisibleNumbers(int leftNum, int rigthNum)
        {
            List<int> listAllNums = SeachNumber(leftNum, rigthNum);

            if (listAllNums.Count > 0) {

                List<string> numsDivision = listAllNums.Select(item => item.ToString())
                                                       .Where(item => !item.Contains('0'))
                                                       .ToList();

                List<string> division = numsDivision.Select(item => item.Trim('-')).ToList();

                List<int> outPutList = new List<int>();

                int tmp = 0;

                bool isDivision = true;

                for (int i = 0; i < numsDivision.Count; i++)
                {
                    int.TryParse(numsDivision[i], out tmp);

                    var div = division[i].Select(item => int.Parse(item.ToString())).ToList();

                    isDivision = div.All(item => tmp % item == 0);

                    if (isDivision == true)
                    {
                        outPutList.Add(tmp);
                    }
                }

                return outPutList;
            }

            return listAllNums;
        }

        public List<int> SeachNumber(int leftNum, int rigthNum)
        {
            List<int> listNums = new List<int>();

            if (rigthNum > leftNum)
            {
                for (int i = leftNum; i <= rigthNum; i++)
                {
                    listNums.Add(i);
                }
            }
            if (rigthNum < leftNum)
            {
                for (int i = rigthNum; i <= leftNum; i++)
                {
                    listNums.Add(i);
                }
            }
            else if (rigthNum == leftNum)
            {
                listNums.Add(leftNum);
            }

            return listNums;
        }
    }
}
