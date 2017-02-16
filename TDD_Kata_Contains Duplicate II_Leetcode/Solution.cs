using System;

namespace TDD_Kata_Contains_Duplicate_II_Leetcode
{
    internal class Solution
    {
        internal object ContainsNearByDuplicate(int[] nums, int k)
        {
            if(k <= 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < nums.Length-1; i++)
                {
                    for(int j = i+1; j< nums.Length; j++ )
                    {
                        if (nums[j] == nums[i] && Math.Abs(j - i) <= k)
                            return true;
                    }
                }
                return false;
            }
            
        }
    }
}