using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
            int tmp = n;
            List<int> ternary = new List<int>();
            int result = 0;
            while(tmp != 0)
            {
                ternary.Add(tmp % 3);
                tmp /= 3;
            }
            for (int i = 0; i < ternary.Count; i++)
                result += ternary[i] * (int)Math.Pow(3, ternary.Count - i - 1);
            return result;
    }
}
