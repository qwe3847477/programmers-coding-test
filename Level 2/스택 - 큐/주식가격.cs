using System;

public class Solution {
    public int[] solution(int[] prices) {
            int[] answer = new int[prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                int value = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] <= prices[j])
                        value++;
                    else
                    {
                        value++;
                        break;
                    }
                }
                answer[i] = value;
            }
            return answer;
    }
}
