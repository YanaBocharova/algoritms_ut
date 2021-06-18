using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class ArrayUniqueNumbersTest
    {
        [TestMethod]
        public void ArrayUniqueNumbers_InputNull_ReturnFalse()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayUniqueNumbers();

            // act
            var result = ArrayNumTestObj.IsUniqueValue(null);

            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ArrayUniqueNumbers_InputEmpty_ReturnFalse()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayUniqueNumbers();

            int[] arr = { };
            // act
            var result = ArrayNumTestObj.IsUniqueValue(arr);

            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ArrayUniqueNumbers_InputArrayUnigue_ReturnTrue()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayUniqueNumbers();

            int[] arr = { 1, 12, 32, 2, 22, 0, 33 };
            // act
            var result = ArrayNumTestObj.IsUniqueValue(arr);

            // assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ArrayUniqueNumbers_InputArrayNotUnigue_ReturnFalse()
        {
            // arrange 
            var ArrayNumTestObj = new ArrayUniqueNumbers();

            int[] arr = { 1, 12, 32,32, 2, 22, 0, 33 };
            // act
            var result = ArrayNumTestObj.IsUniqueValue(arr);

            // assert
            Assert.AreEqual(false, result);
        }
    }
}
