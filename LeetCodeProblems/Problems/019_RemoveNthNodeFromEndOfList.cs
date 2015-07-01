using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
//      Given a linked list, remove the nth node from the end of list and return its head.
//      For example,
//          Given linked list: 1->2->3->4->5, and n = 2.
//          After removing the second node from the end, the linked list becomes 1->2->3->5.
//      Note:
//          Given n will always be valid.
//          Try to do this in one pass.
    class _019_RemoveNthNodeFromEndOfList
    {
        public LinkedListNode<int> RemoveNthFromEnd(LinkedListNode<int> head, int n)
        {
            LinkedListNode<int> p1 = head;
            LinkedListNode<int> p2 = head;
            int pdiff = 0;

            while (p1.Next != null)
            {
                if (pdiff == n)
                {
                    p1 = p1.Next;
                    p2 = p2.Next;
                }
                else
                {
                    p1 = p1.Next;
                }
            }
            // cant implement my idea in c# but can in java.
            //p2.Next = p2.Next.Next;
            return head;
        }
    }
}
