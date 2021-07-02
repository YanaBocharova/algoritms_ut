using System;
using System.Collections.Generic;
using System.Linq;

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

            //ShowReverseElementString();

            //ShowLuckyIntengerInArray();

            // ShowResultIsPalidromString();

             ShowMiddleNodeLinked();

            Console.Read();
        }

        private static void ShowMiddleNodeLinked()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            SeachMiddleNode seachNode = new SeachMiddleNode();

            var resultNode = seachNode.SeachNode(list);

            Console.WriteLine($"middle node is {resultNode.Value}");
        }
      
        private static void ShowResultIsPalidromString()
        {
            IsStringPalidrom stringPalidrom = new IsStringPalidrom();

            string inputStr = "asVsa";

            var isPalidrom = stringPalidrom.CheckString("");

            Console.WriteLine($"String is palidrom = {isPalidrom}");
        }

        private static void ShowLuckyIntengerInArray()
        {
            LuckyIntengerInArray luckyIntenger = new LuckyIntengerInArray();

            int[] arr = { 2, 2, 3, 3, 3, 7, 11 };

            var luckyNumber = luckyIntenger.SeachLuckyInterger(arr);

            Console.WriteLine($"lucky number = {luckyNumber}");
        }

        private static void ShowReverseElementString()
        {
            try
            {
                ReverseElementString reverseElementString = new ReverseElementString();

                string str = ("Good morning");

                var revStr = reverseElementString.ReverceString(str);

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
