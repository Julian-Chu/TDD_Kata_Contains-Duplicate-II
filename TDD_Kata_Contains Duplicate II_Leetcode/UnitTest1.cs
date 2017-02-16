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

        //Business logic: k must be greater than 0
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

        [TestMethod]
        public void ContainsNearByDuplicate_Give_nums_1_2_kIs1_Returns_false()
        {
            //Assign
            int[] nums = { 1, 2};
            int k = 1;

            //Act
            var expected = false;
            var actual = solution.ContainsNearByDuplicate(nums, k);

            //Assert
            Assert.AreEqual(expected,  actual);
        }

        [TestMethod]
        public void ContainsNearByDuplicate_Give_nums_1_1_kIs1_Returns_true()
        {
            //Assign
            int[] nums = { 1, 1 };
            int k = 1;

            //Act
            var expected = true;
            var actual = solution.ContainsNearByDuplicate(nums, k);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainsNearByDuplicate_Give_nums_1_2_1_kIs1_Returns_false()
        {
            //Assign
            int[] nums = { 1, 2, 1 };
            int k = 1   ;

            //Act
            var expected = false;
            var actual = solution.ContainsNearByDuplicate(nums, k);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainsNearByDuplicate_Give_nums_2_5_67_4_5_6_1_kIs1_Returns_false()
        {
            //Assign
            int[] nums = { 2,5,67,4,5,6,1 };
            int k = 1;

            //Act
            var expected = false;
            var actual = solution.ContainsNearByDuplicate(nums, k);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainsNearByDuplicate_Give_nums_2_5_67_4_5_6_1_kIs4_Returns_true()
        {
            //Assign
            int[] nums = { 2, 5, 67, 4, 5, 6, 1 };
            int k = 4;

            //Act
            var expected = true;
            var actual = solution.ContainsNearByDuplicate(nums, k);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
