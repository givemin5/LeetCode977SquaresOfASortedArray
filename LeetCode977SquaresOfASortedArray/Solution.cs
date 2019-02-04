using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode977SquaresOfASortedArray
{
    public class Solution
    {
        public int[] SortedSquares(int[] A)
        {
            return A.Select(x => x * x).OrderBy(x => x).ToArray();
        }
    }
}
