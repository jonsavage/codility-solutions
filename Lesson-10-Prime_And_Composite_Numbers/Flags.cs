using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
using System.Linq;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var peaks = Enumerable.Repeat(0, A.ToList().Count).ToArray();

        for(int i = 0; i < A.Length - 2; i++) {
            if (HasPeak(A[i], A[i+1], A[i+2]))
                peaks[i+1] = 1;
        }

        var peakCount = peaks.ToList().Count(x => x == 1);
        var peaksToSubtract = 0;
        var distance = 0;
        var hasPreviousPeak = false;

        for (int i = 0; i < peaks.Length; i++) {
            if(peaks[i] == 1) {
                if(hasPreviousPeak && distance >= peakCount)
                    peaksToSubtract++;
                hasPreviousPeak = true;
                distance = 0;
            }
            else
                distance++;
        }

        return peakCount - peaksToSubtract;
    }

    public bool HasPeak(int a, int b, int c) {
        return b > a && b > c;
    }
}
