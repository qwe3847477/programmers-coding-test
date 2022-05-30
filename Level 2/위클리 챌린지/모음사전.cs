using System;

public class Solution
{
    public int solution(string word)
    {
        int answer = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'A')
                answer += 1;
            else if (word[i] == 'E')
                answer += 1 + Geometric(5, 1, 5 - i);
            else if (word[i] == 'I')
                answer += 1 + 2 * Geometric(5, 1, 5 - i);
            else if (word[i] == 'O')
                answer += 1 + 3 * Geometric(5, 1, 5 - i);
            else if (word[i] == 'U')
                answer += 1 + 4 * Geometric(5, 1, 5 - i);
        }

        return answer;
    }

    int Geometric(int ratio, int n1, int n)
    {
        int result = 0;
        for (int i = 0; i < n; i++)
            result += n1 * (int)Math.Pow(ratio, i);
        return result;
    }  
}
