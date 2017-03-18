using System;
using System.Linq;

class Solution {
    public int solution(int[] A)
        =>
          A.GroupBy(x => x)
           .Where(x => x.Count() % 2 != 0)
           .FirstOrDefault()
           .Key;
}
