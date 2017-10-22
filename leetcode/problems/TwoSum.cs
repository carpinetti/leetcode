using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcode.problems
{
    public class TwoSum
    {
        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// </summary>
        public int[] Solution(int[] nums, int target)
        {
            // Número de combinações possívels = n!/[(n-p)! p!]
            for (int i = 0; i < nums.Length; i++)
            {
                for (int y = i + 1; y < nums.Length; y++)
                {
                    if ((nums[i] + nums[y]) == target)
                        return new int[] { i, y };
                }
            }

            return null;
        }

        public int[] Solution2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int y = Array.FindIndex(nums, i + 1, x => (nums[i] + x) == target);
                if (y >= 0)
                    return new int[] { i, y };
            }

            return null;
        }

        public int[] Solution3(int[] nums, int target)
        {
            var result = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int b = target - nums[i];
                if (result.ContainsKey(b) && result[b] != i)
                    return new int[] { result[b], i };

                result[nums[i]] = i;
            }

            return null;
        }
}
}
