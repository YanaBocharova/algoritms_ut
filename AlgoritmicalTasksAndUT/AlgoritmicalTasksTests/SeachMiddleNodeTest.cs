using AlgoritmicalTasksAndUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksTests
{
    [TestClass]
    public class SeachMiddleNodeTest
    {
        [TestMethod]
        public void SeachMiddleNodeTest_InputListEvenCounts_ReturnNode()
        {
            // arrange 
            var TestObj = new SeachMiddleNode();

            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            LinkedListNode<int> node = list.First.Next.Next;

            // act
            var result = TestObj.SeachNode(list);

            // assert
            Assert.AreEqual(node, result);
        }

        [TestMethod]
        public void SeachMiddleNodeTest_InputListOddCounts_ReturnNode()
        {
            // arrange 
            var TestObj = new SeachMiddleNode();

            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            LinkedListNode<int> node = list.First.Next;

            // act
            var result = TestObj.SeachNode(list);

            // assert
            Assert.AreEqual(node, result);
        }

        [TestMethod]
        public void SeachMiddleNodeTest_InputListWitOneNode_ReturnThisNode()
        {
            // arrange 
            var TestObj = new SeachMiddleNode();

            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(7);

            LinkedListNode<int> node = list.First;

            // act
            var result = TestObj.SeachNode(list);

            // assert
            Assert.AreEqual(node, result);
        }
    }
}
