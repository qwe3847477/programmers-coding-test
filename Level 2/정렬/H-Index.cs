using System;
using System.Linq;

public class Solution {
    public int solution(int[] citations) {
            int answer = 0;
            citations = citations.OrderByDescending(c => c).ToArray();
            for (int i = 0; i < citations.Length; i++)
                if (citations[i] >= i + 1)
                    answer = i + 1;
            return answer;
    }
}
