using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgoritmicalTasksAndUT
{
    public class StringConsistentAnycharacters
    {
        public int CountApearValues(string allowedSymb, List<string> words)
        {
            List<string> listAnswrers = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (allowedSymb.ToCharArray().All(item => words[i].Contains(item)))
                {
                    listAnswrers.Add(words[i]);
                }
            }
 
            return listAnswrers.Count;
        }
    }
}
