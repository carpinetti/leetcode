using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.problems;
using System.Collections.Generic;
using System.Linq;

namespace leetcodeTest
{
    [TestClass]
    public class ReverseLinkedListBetweenTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ListNode[] nodes = new ListNode[5];

            for (int i = 0; i < 5; i++)
            {
                nodes[i] = new ListNode(i + 1);
            }

            for (int i = 4; i > 0; i--)
            {
                nodes[i - 1].next = nodes[i];
            }
            var test = new LinkedList();
            var r = test.ReverseBetween(nodes[0], 2, 4);
        }
    }
}
