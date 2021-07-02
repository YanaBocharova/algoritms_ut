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
                var seachnode = list.First;

                while (current.Next != null && current != null)
                {
                    if (current.Next.Next == null)
                    {
                        return seachnode.Next;
                    }
                    current = current.Next.Next;
                    seachnode = seachnode.Next;
                }

                return seachnode;
            }

            return list.First;
        }
    }  
}
