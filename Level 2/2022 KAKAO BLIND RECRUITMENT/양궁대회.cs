using System;

internal class Solution
{
    int answer = 0;
    int[] answerArr = new int[11];


    public int[] solution(int n, int[] info)
    {
        DFS(0, n, new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0, info);

        if (answer == 0)
            return new int[1] { -1 };
        else
            return answerArr;
    }

    private void DFS(int count, int n, int[] arr, int k, int[] info)
    {


        if (count == n)
        {
            Score(arr, info);
            return;
        }

        int[] tmpArr = new int[11];
        Array.Copy(arr, tmpArr, 11);

        for (int i = k; i < 11; i++)
        {
            tmpArr[i] += 1;
            DFS(count + 1, n, tmpArr, k, info);
            k++;
            tmpArr[i] -= 1;
        }
    }

    private void Score(int[] result, int[] info)
    {
        int lion = 0;
        int peach = 0;
        for (int i = 0; i < 11; i++)
        {
            if (result[i] > info[i])
                lion += (10 - i);
            else if (result[i] < info[i] && info[i] != 0)
                peach += (10 - i);
            else if (result[i] == info[i] && info[i] != 0)
                peach += (10 - i);

        }

        if (peach >= lion)
            return;
        else if ((lion - peach) > answer)
        {
            answer = lion - peach;
            Array.Copy(result, answerArr, 11);
        }
        else if ((lion - peach) == answer)
        {
            for (int i = 10; i >= 0; i--)
            {
                if (result[i] != 0 || answerArr[i] != 0)
                    if (result[i] > answerArr[i])
                    {
                        Array.Copy(result, answerArr, 11);
                        return;
                    }
                    else
                        return;
            }
        }
    }
}

