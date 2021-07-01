using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class IsStringPalidrom
    {
        public bool CheckString(string inputStr)
        {
            if (inputStr != null && inputStr.Length > 0)
            {
                var arrayChar = inputStr.ToString().ToCharArray();

                var arrayLength = arrayChar.Length;

                for (int i = 0; i < arrayChar.Length / 2; i++)
                {
                    if (arrayChar[i] != arrayChar[(arrayLength - 1) - i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
