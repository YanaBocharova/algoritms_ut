using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class ReplaceElementArrayMaxValueTest
    {
        [TestMethod]
        public void ReplaceElementArrayMaxValueTest_InputArrNumbers_ReturnNewArray()
        {
            //arrange
            ReplaceElementArrayMaxValue arrayMaxValue = new ReplaceElementArrayMaxValue();

            List<int> arr = new List<int> { 12, 18, 2, 3, 6, 1 };

            var output = arrayMaxValue.ReplaceElementMaxValue(arr);

            //act
            List<int> result = new List<int>{ 18, 6, 6, 6, 1, -1 };

            // assert
            CollectionAssert.AreEqual(result, output);
        }

        [TestMethod]
        public void ReplaceElementArrayMaxValueTest_InputArrEqualNumbers_ReturnNewArray()
        {
            //arrange
            ReplaceElementArrayMaxValue arrayMaxValue = new ReplaceElementArrayMaxValue();

            List<int> arr = new List<int> { 8, 8, 8, 8, 8 };

            var output = arrayMaxValue.ReplaceElementMaxValue(arr);

            //act
            List<int> result = new List<int> { 8, 8, 8, 8, -1 };

            // assert
            CollectionAssert.AreEqual(result, output);
        }

        [TestMethod]
        public void ReplaceElementArrayMaxValueTest_InputArrEmpty_ReturnEmptyArr()
        {
            //arrange
            ReplaceElementArrayMaxValue arrayMaxValue = new ReplaceElementArrayMaxValue();

            List<int> arr = new List<int> { };

            var output = arrayMaxValue.ReplaceElementMaxValue(arr);

            //act
            List<int> result = new List<int> {-1};

            // assert
            CollectionAssert.AreEqual(result, output);
        }
    }
}
