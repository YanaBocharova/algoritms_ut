using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class StringContainsOnlyAllowedSymbolsTest
    {
        [TestMethod]
        public void StringConsistentAnycharactersTest_InputStringtAnyEquls_ReturnResult5()
        {
            // arrange 
            var TestObj = new StringContainsOnlyAllowedSymbols();

            string allowed = "abc";

            List<string> words = new List<string>() { "bn", "cm", "baa", "cca", "bb", "ac" };

            int count = 4;

            // act
            var result = TestObj.CountWordContainsAlloedValues(allowed, words);

            // assert
            Assert.AreEqual(count, result);
        }

        [TestMethod]
        public void StringConsistentAnycharactersTest_InputNotAnyEquls_ReturnZero()
        {
            // arrange 
            var TestObj = new StringContainsOnlyAllowedSymbols();

            string allowed = "ab";

            List<string> words = new List<string>() { "cx", "mmm", "abn", "oo" };

            int count = 0;

            // act
            var result = TestObj.CountWordContainsAlloedValues(allowed, words);

            // assert
            Assert.AreEqual(count, result);
        }
    }
}
