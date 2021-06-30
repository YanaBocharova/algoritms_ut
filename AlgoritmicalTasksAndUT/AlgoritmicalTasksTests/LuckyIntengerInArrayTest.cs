using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class LuckyIntengerInArrayTest
    {
        [TestMethod]
        public void LuckyIntengerInArray_InputNull_ReturnMinusOne()
        {
            // arrange 
            var ArrayNumTestObj = new LuckyIntengerInArray();

            // act
            var result = ArrayNumTestObj.SeachLuckyInterger(null);

            // assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void LuckyIntengerInArray_InputEmptyArray_ReturnMinusOne()
        {
            // arrange 
            var ArrayNumTestObj = new LuckyIntengerInArray();

            int[] arr = { };
            // act
            var result = ArrayNumTestObj.SeachLuckyInterger(arr);

            // assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void LuckyIntengerInArray_InputNumbersArray_ReturnMaxValue()
        {
            // arrange 
            var ArrayNumTestObj = new LuckyIntengerInArray();

            int[] arr = { 4, 4, 4, 4, 2, 2, 3, 3, 3 };

            int number = 4;
            // act
            var result = ArrayNumTestObj.SeachLuckyInterger(arr);

            // assert
            Assert.AreEqual(number, result);
        }

        [TestMethod]
        public void LuckyIntengerInArray_InputNotContainLuckyNumbersArray_ReturnMinusOne()
        {
            // arrange 
            var ArrayNumTestObj = new LuckyIntengerInArray();

            int[] arr = { 4 };

            int number = -1;
            // act
            var result = ArrayNumTestObj.SeachLuckyInterger(arr);

            // assert
            Assert.AreEqual(number, result);
        }
    }
}
