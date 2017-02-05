using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if (A.Length < 3)
            return 0;

        var sorted = A.ToList();
        sorted.Sort();

        foreach (var index in Enumerable.Range(0, sorted.Count() - 2))
            if (triangleIsPossible(sorted.ElementAt(index), sorted.ElementAt(index + 1), sorted.ElementAt(index + 2)))
                return 1;

        return 0;
    }

    private bool triangleIsPossible(long a, long b, long c)
        => a + b > c;
}
