using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class ArrayStringByConditionTest
    {
        [TestMethod]
        public void ArrayStringByConditionTest_InputEmptyArr_ReturnEmptyArray()
        {
            //arrange
            var ArrayNumTestObj = new ArrayStringByCondition();

            List<string> arr = new List<string>();

            int[] arrInput = { };

            //act
            var result = ArrayNumTestObj.CreateArrayStringByConditionInputArray(arrInput);

            // assert
            CollectionAssert.AreEquivalent(arr, result);
        }

        [TestMethod]
        public void ArrayStringByConditionTest_InputArray_ReturnListString()
        {
            //arrange
            var ArrayNumTestObj = new ArrayStringByCondition();

            int[] arr = { 15, 3 , 5 , 4 };

            List<string> resultStr = new List<string>{ "FizzBuzz", "Fizz", "Buzz", "4" };

            //act
            var result = ArrayNumTestObj.CreateArrayStringByConditionInputArray(arr);

            //assert
            CollectionAssert.AreEquivalent(resultStr, result);
        }
    }
}
