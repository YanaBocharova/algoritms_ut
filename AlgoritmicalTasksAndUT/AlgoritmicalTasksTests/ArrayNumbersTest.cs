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
    }
}
