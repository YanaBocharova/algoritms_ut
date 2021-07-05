using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmicalTasksAndUT
{
    public class SeachMiddleNode
    {
        public LinkedListNode<int> SeachNode(LinkedList<int> list)
        {
            if (list.Count > 1)
            {
                var current = list.First;
                var searchNode = list.First;

                while (current.Next != null)
                {
                    if (current.Next.Next == null)
                    {
                        return searchNode.Next;
                    }
                    current = current.Next.Next;
                    searchNode = searchNode.Next;
                }

                return searchNode;
            }

            return list.First;
        }
    }  
}
