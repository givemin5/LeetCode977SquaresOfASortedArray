using System;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode977SquaresOfASortedArray
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] A = new[] {-4, -1, 0, 3, 10};

            var solution = new Solution();

            var actual = solution.SortedSquares(A);
            int[] expected = new[] {0, 1, 9, 16, 100};

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
