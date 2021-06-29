using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class StringConsistentAnycharactersTest
    {
        [TestMethod]
        public void StringConsistentAnycharactersTest_InputStringtAnyEquls_ReturnResult()
        {
            // arrange 
            var TestObj = new StringConsistentAnycharacters();

            string allowed = "ab";

            List<string> words = new List<string>() { "ad", "bn", "aaab", "baa", "badab", "nn", "word" };

            int count = 5;

            // act
            var result = TestObj.CountApearValues(allowed, words);

            // assert
            Assert.AreEqual(count, result);
        }

        [TestMethod]
        public void StringConsistentAnycharactersTest_InputNotAnyEquls_ReturnZero()
        {
            // arrange 
            var TestObj = new StringConsistentAnycharacters();

            string allowed = "ab";

            List<string> words = new List<string>() { "word","mmm","sdfsdfs","oo" };

            int count = 0;

            // act
            var result = TestObj.CountApearValues(allowed, words);

            // assert
            Assert.AreEqual(count, result);
        }
    }
}
