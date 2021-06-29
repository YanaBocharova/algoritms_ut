using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgoritmicalTasksAndUT
{
    public class StringContainsOnlyAllowedSymbols
    {
        private string pattern = string.Empty;

        List<string> words = new List<string>();

        List<string> listAnswrers = new List<string>();
        public int CountWordContainsAlloedValues(string allowedSymb, List<string> wordsList)
        {
            pattern = $"^[{allowedSymb}]+$";

            words = wordsList;

            for (int i = 0; i < words.Count; i++)
            {
               if ( Regex.IsMatch(words[i], pattern))
               {
                    listAnswrers.Add(words[i]);
               }
            }

            return listAnswrers.Count;
        }
    }
}
