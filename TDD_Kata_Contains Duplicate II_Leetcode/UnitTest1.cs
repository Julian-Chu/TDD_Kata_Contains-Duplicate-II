using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_Kata_Contains_Duplicate_II_Leetcode
{
    [TestClass]
    public class UnitTest1
    {
        Solution solution;
        [TestInitialize]
        public void Initialize()
        {
            solution = new Solution();
        }

        //Business logic: k must bigger than 0
        [TestMethod]
        public void ContainsNearbyDuplicate_Given_kIsZero_Return_False()
        {
            //Assign
            int[] nums = { 1, 2, 3, 4, 1 };
            int k = 0;

            //Act
            var expected = false;
            var actual = solution.ContainsNearByDuplicate(nums, k);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
