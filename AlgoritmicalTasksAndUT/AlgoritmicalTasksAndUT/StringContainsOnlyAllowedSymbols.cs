using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgoritmicalTasksAndUT
{
    public class StringContainsOnlyAllowedSymbols
    {
        public int CountWordContainsAlloedValues(string allowedSymb, List<string> words)
        {
            List<string> listAnswrers = new List<string>();

            string pattern = $"^[{allowedSymb}]+$";

            for (int i = 0; i < words.Count; i++)
            {
               if (Regex.IsMatch(words[i], pattern))
               {
                    listAnswrers.Add(words[i]);
               }
           }

           return listAnswrers.Count;
        }
    }
}
