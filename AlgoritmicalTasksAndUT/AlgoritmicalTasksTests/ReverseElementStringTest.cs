using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{

    [TestClass]
    public class ReverseElementStringTest
    {
        [TestMethod]
        public void StringConsistentAnycharactersTest_InputStringt_ReturnReverseString()
        {
            // arrange 
            var TestObj = new  ReverseElementString();

            string str = ("Good word");

            string reverseStr = ("dooG drow ");

            // act
            var result = TestObj.ReverceString(str);

            // assert
            Assert.AreEqual(reverseStr, result);
        }

        [TestMethod]
        public void StringConsistentAnycharactersTest_InputEmptyStringt_ReturnEmptyString()
        {
            // arrange 
            var TestObj = new ReverseElementString();

            string str = string.Empty;

            string reverseStr = " ";

            // act
            var result = TestObj.ReverceString(str);

            // assert
            Assert.AreEqual(reverseStr, result);
        }
    }
}