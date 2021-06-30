using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class ReverseElementString
    {
        public string ReverceString(string str)
        {
            if(str == null)
            {
                throw new Exception();
            }
            if (str.Length == 0)
            {
                return string.Empty;
            }
            List<string> arrayString = str.Split(' ').ToList();

            StringBuilder builder = new StringBuilder();

            arrayString.ForEach(item => builder.Append(new string(item.ToCharArray().Reverse().ToArray()) + ' '));

            var reverStr = builder.ToString().Remove(builder.Length-1);

            return reverStr;
        }
    }
}
