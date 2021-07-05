using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class IsStringPalidrom
    {
        public bool CheckString(string inputStr)
        {
            if (inputStr == null || inputStr.Length == 0)
            {
                return false;
            }

            var arrayLength = inputStr.Length;

            for (int i = 0; i < arrayLength / 2; i++)
            {
                if (inputStr[i] != inputStr[(arrayLength - 1) - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
