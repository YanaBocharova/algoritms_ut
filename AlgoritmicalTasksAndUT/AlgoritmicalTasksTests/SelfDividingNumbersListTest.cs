using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class SelfDividingNumbersListTest
    {
        [TestMethod]
        public void SelfDividingNumbersListTest_InputZeroValue_ReturnEmptyList()
        {
            // arrange 
            var ListNumTestObj = new SelfDividingNumbersList();
            
            int left = 0;
            int right = 0;

            List<int> outPutList = new List<int> { };

            // act
            var result = ListNumTestObj.SeachSelfDivisibleNumbers(left, right);

            // assert
            CollectionAssert.AreEqual(outPutList, result);
        }

        [TestMethod]
        public void SelfDividingNumbersListTest_InputValues_ReturnResultList()
        {
            // arrange 
            var ArrayNumTestObj = new SelfDividingNumbersList();

            int left = 120;
            int right = 128;

            List<int> outPutList = new List<int> { 122, 124, 126, 128 };

            // act
            var result = ArrayNumTestObj.SeachSelfDivisibleNumbers(left, right);

            // assert
            CollectionAssert.AreEqual(outPutList, result);
        }
    }
}
