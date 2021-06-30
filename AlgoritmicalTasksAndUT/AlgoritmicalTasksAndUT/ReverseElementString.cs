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
            List<string> s = str.Split(' ').ToList();

            StringBuilder builder = new StringBuilder();

            s.ForEach(item => builder.Append(new string(item.ToCharArray().Reverse().ToArray()) + ' '));

            var reverStr = builder.ToString();

            return reverStr;
        }
    }
}
