using System;
using System.Linq;

public class Solution {
    public int[] solution(string s) {
            int[] answer = new int[] { 0, 0 };

            while (!s.Equals("1"))
            {
                answer[0]++;
                var OneCharCount = s.Where(x => x.Equals('1')).Count();
                answer[1] += s.Length - OneCharCount;

                s = Convert.ToString(OneCharCount, 2);
            }

            return answer;
    }
}
