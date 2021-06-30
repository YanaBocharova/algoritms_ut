using System;
using System.Collections.Generic;

namespace AlgoritmicalTasksAndUT
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowResultArrayNumbers();

            //ShowResulIterationValueArray();

            //ShowResulItSortEvenNumberAtEvenIndex();

            //ShowReturnListAnswers();

            //ShowStringConsistentAnycharacters();

            //ShowStringContainsOnlyAllowedSymbols();

            //ShowReplaceElementArrayMaxValue();

            ShowReverseElementString();

            Console.Read();
        }

        private static void ShowReverseElementString()
        {
            try
            {
                ReverseElementString reverseElementString = new ReverseElementString();

                string str = ("Good morning");

                var revStr = reverseElementString.ReverceString("");

                Console.WriteLine(revStr);
            }
            catch (Exception)
            {
                Console.WriteLine("string  == null");
            }
        }

        private static void ShowReplaceElementArrayMaxValue()
        {
            ReplaceElementArrayMaxValue arrayMaxValue = new ReplaceElementArrayMaxValue();

            List<int> arr = new List<int> { 12, 18, 2, 3, 6, 1 };

            var output = arrayMaxValue.ReplaceElementMaxValue(arr);

            output.ForEach(item =>
            {
                Console.Write($"{item,3}");
            });
        }

        private static void ShowStringContainsOnlyAllowedSymbols()
        {
            StringContainsOnlyAllowedSymbols stringContains = new StringContainsOnlyAllowedSymbols();

            string allowed = "abc";

            List<string> words = new List<string>() { "bn","cm", "baa", "cca", "bb","ac"};

            var count = stringContains.CountWordContainsAlloedValues(allowed, words);

            Console.WriteLine($" count = {count}");
        }

        private static void ShowStringConsistentAnycharacters()
        {
            StringConsistentAnycharacters stringConsistent = new StringConsistentAnycharacters();

            string allowed = "ab";

            List<string> words = new List<string>() { "ad", "bn", "aaab", "baa", "nn", "word" };

            var count = stringConsistent.CountApearValues(allowed, words);

            Console.WriteLine($"count words = {count}");
        }

        private static void ShowReturnListAnswers()
        {
            ArrayStringByCondition arrayStringBy = new ArrayStringByCondition();

            int[] arr = { 3 , 4 , 5 , 15 , 30 , -1};

            try
            {
                var strArr = arrayStringBy.CreateArrayStringByConditionInputArray(arr);

                strArr.ForEach(str =>
                {
                    Console.WriteLine(str);
                });
            }
            catch(Exception)
            {
                Console.WriteLine(" arr is null");
            }
        }

        private static void ShowResulItSortEvenNumberAtEvenIndex()
        {
            ArraySortByOddEvenValueIndex ArrayNumTestObj = new ArraySortByOddEvenValueIndex();

            int[] arr = { 3 , 3 , 2 , 3 , 22 };

            try
            {
                var sortArr = ArrayNumTestObj.SortArrayEvenNumberAtEvenIndex(arr);

                foreach (var item in sortArr)
                {
                    Console.Write($"{item,5}");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("sortArr is null");
            }
        }

        private static void ShowResulIterationValueArray()
        {
            ArrayUniqueValueCountOccur ArrayNumTestObj = new ArrayUniqueValueCountOccur();

            int[] arr = { 1 , 1 , 2 , 3 , 3 , 3 , 3 };
           
            var result = ArrayNumTestObj.IsUniqueIterationValue(arr);

            Console.WriteLine($"iteration unique values = {result}");
        }

        private static void ShowResultArrayNumbers()
        {
            int[] arr = { 1 , 2 , 2 , 6 , 6 , 6 , 6 , 7 , 10 };

            ArrayNumbers array = new ArrayNumbers();

            int foundNumber = array.ReturnNumber(arr);

            Console.WriteLine($"found integer= {foundNumber}");
        }
    }
}
