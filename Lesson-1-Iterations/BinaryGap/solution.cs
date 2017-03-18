using System;

class Solution {
    public int solution(int number) {
        var binaryString = Convert.ToString(number, 2);

        var max = 0;
        var count = 0;

        foreach(var i in binaryString) {
            if(i == '0') {
              count++;
            }
            else {
              max = Math.Max(count, max);
              count = 0;
            }
        }
        return max;
    }
}
