using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    public class LinkedList
    {
        public ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }

            return prev;

        }

        public ListNode ReverseBetween1(ListNode head, int m, int n)
        {
            ListNode dummyNode = new ListNode(0)
            {
                next = head
            };

            ListNode cur = head;
            ListNode prev = null;
            ListNode next = null;
            ListNode revHead = dummyNode;
            ListNode subListTail = null;
            int count = 1;

            if (head == null || head.next == null)
                return head;

            while (cur != null && count++ < m)
            {
                revHead = cur;
                prev = cur;
                cur = cur.next;
            }

            while (cur != null && count <= n)
            {
                if (count == m) subListTail = cur;

                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;

                if (count == n)
                {
                    subListTail.next = cur;
                    revHead.next = prev;
                }

                count++;
            }

            return dummyNode.next;
        }

        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode subHead = new ListNode(0);
            ListNode subTail = new ListNode(0);
            ListNode tCur = dummy;
            ListNode cur = head;
            int count = 1;

            while (count <= n)
            {
                ListNode temp = cur.next;
                if (count < m)
                {
                    tCur = cur;
                }
                else if (count == m)
                {
                    subTail = cur;
                    subHead.next = cur;
                }
                else if (count > m)
                {
                    cur.next = subHead.next;
                    subHead.next = cur;
                }

                cur = temp;
                ++count;
            }

            tCur.next = subHead.next;
            subTail.next = cur;

            return dummy.next;
        }

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

    }
}
