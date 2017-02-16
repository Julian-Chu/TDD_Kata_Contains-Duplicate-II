using System.Collections.Generic;

namespace TDD_Kata_Contains_Duplicate_II_Leetcode
{
    internal class Solution
    {
        internal object ContainsNearByDuplicate(int[] nums, int k)
        {
            if (k <= 0) return false;

            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) && i - dict[nums[i]] <= k)
                    return true;
                if (i >= k) dict.Remove(nums[i - k]);
                dict.Add(nums[i], i);
            }

            return false;
        }
    }
}