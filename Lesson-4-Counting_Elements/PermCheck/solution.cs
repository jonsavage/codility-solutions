using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        var sorted = A.OrderBy(i => i);

        if (sorted.First() != 1)
            return 0;

        var sortedDistinct = sorted.Distinct();

        if (sorted.Count() != sortedDistinct.Count())
            return 0;

        if (sortedDistinct.Max() != sortedDistinct.Count())
            return 0;

        return 1;
    }
}
