using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class ArrayNumbersTest
    {
        [TestMethod]
        public void ArrayNumbers_InputNull_ReturnMinusOne()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayNumbers();

            // act
            var result = ArrayNumTestObj.ReturnNumber(null);

            // assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void ArrayNumbers_InputEmptyArray_ReturnMinusOne()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayNumbers();

            // act
            var result = ArrayNumTestObj.ReturnNumber(null);

            // assert
            Assert.AreEqual(-1, result);
        }


        [TestMethod]
        public void ArrayNumbers_InputSortArray_ReturnValue()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayNumbers();

            int[] arr = { 1, 2, 2, 6, 6, 6, 6, 7, 10 };

            // act
            int result = ArrayNumTestObj.ReturnNumber(arr);

            // assert
            Assert.AreEqual(6, result);
        }
    }
}
