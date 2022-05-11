using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int n, long left, long right) 
    {
        int[] answer = new int[right - left + 1];
        int index = 0;
        for (long i = left; i < right + 1; i++)
        {
            answer[index] = (int)(Math.Max(i / (long)n, i % (long)n) + 1);
            index++;
        }
        return answer;
    }
}
