using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using AlgoritmicalTasksAndUT;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class ArrayUniqueValueCountOccurTest
    {
        [TestMethod]
        public void ArrayUniqueNumbers_InputNull_ReturnFalse()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayUniqueValueCountOccur();

            // act
            var result = ArrayNumTestObj.IsUniqueIterationValue(null);

            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ArrayUniqueNumbers_InputEmpty_ReturnFalse()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayUniqueValueCountOccur();

            int[] arr = { };
            // act
            var result = ArrayNumTestObj.IsUniqueIterationValue(arr);

            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ArrayUniqueIterationNumbers_InputArrayUnigue_ReturnTrue()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayUniqueValueCountOccur();

            int[] arr = { 1 , 1 , 2 , 22 , 22 , 22 , 3 , 3 , 3 , 3 };
            // act
            var result = ArrayNumTestObj.IsUniqueIterationValue(arr);

            // assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ArrayUniqueIterationNumbers_InputArrayUnigue_ReturnFalse()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayUniqueValueCountOccur();

            int[] arr = { 1 , 1 , 2 , 2 , 22 , 22 , 22 , 22 , 3 , 3 , 3 , 3 };
            // act
            var result = ArrayNumTestObj.IsUniqueIterationValue(arr);

            // assert
            Assert.AreEqual(false, result);
        }
    }
}

