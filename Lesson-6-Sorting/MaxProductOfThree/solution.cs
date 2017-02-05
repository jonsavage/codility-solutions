using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Linq;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        var productOfThreeLargest = A.ToList().OrderByDescending(x => x).Take(3).Aggregate(1, (acc, val) => acc * val);

        var largest = A.ToList().OrderByDescending(x => x).Take(1);
        var twoSmallest = A.ToList().OrderBy(x => x).Take(2);

        var productOfTwoSmallestAndSingleLargest = twoSmallest.Concat(largest).Aggregate(1, (acc, val) => acc * val);

        return productOfThreeLargest > productOfTwoSmallestAndSingleLargest ? productOfThreeLargest : productOfTwoSmallestAndSingleLargest;
    }
}
