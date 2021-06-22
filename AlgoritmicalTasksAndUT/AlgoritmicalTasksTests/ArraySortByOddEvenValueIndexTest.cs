using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class ArraySortByOddEvenValueIndexTest
    {
        [TestMethod]
        public void ArraySortByOddEvenValueIndex_InputEmpty_ReturnEmptyArray()
        {

            //arrange
            var ArrayNumTestObj = new ArraySortByOddEvenValueIndex();

            int[] arr = { };

            //act
            var result = ArrayNumTestObj.SortArrayEvenNumberAtEvenIndex(arr);

            // assert
            Assert.AreEqual(arr, result);
        }

        [TestMethod]
        public void ArraySortByOddEvenValueIndex_InputArray_ReturnSortedArray()
        {

            //arrange
            var ArrayNumTestObj = new ArraySortByOddEvenValueIndex();

            int[] arr = { 3, 3, 22, 4, 2 };

            int[] sortArr = { 2 , 3 , 4 , 3 , 22 };

            //act
            var result = ArrayNumTestObj.SortArrayEvenNumberAtEvenIndex(arr);

            //assert
            CollectionAssert.AreEqual(sortArr, result);
        }

    }
}
