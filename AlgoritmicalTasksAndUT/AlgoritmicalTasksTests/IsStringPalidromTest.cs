using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class IsStringPalidromTest
    {
        [TestMethod]
        public void IsStringPalidromTest_InputStringtPalidrom_ReturnTrue()
        {
            // arrange 
            var TestObj = new IsStringPalidrom();

            string str = "xcAcx";

            bool result = true;

            // act
            var resultObj = TestObj.CheckString(str);

            // assert
            Assert.AreEqual(result, resultObj);
        }

        [TestMethod]
        public void IsStringPalidromTest_InputStringtPalidrom_ReturnFalse()
        {
            // arrange 
            var TestObj = new IsStringPalidrom();

            string str = "xcAcxm";

            bool result = false;

            // act
            var resultObj = TestObj.CheckString(str);

            // assert
            Assert.AreEqual(result, resultObj);
        }

        [TestMethod]
        public void IsStringPalidromTest_InputNull_ReturnFalse()
        {
            // arrange 
            var TestObj = new IsStringPalidrom();

            bool result = false;

            // act
            var resultObj = TestObj.CheckString(null);

            // assert
            Assert.AreEqual(result, resultObj);
        }
    }
}
