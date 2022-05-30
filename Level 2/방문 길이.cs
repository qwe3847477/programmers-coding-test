using System;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public int solution(string dirs)
    {
        int answer = 0;

        int[] currPos = { 0, 0 };
        List<float[]> list = new List<float[]>();

        char[] dir = dirs.ToCharArray();
        foreach(char c in dir)
        {
            if (c == 'U' && currPos[1] < 5)
            {
                currPos[1]++;
                list.Add(new float[2] { currPos[0], currPos[1] - 0.5f });
            }
            else if (c == 'D' && currPos[1] > -5)
            {
                currPos[1]--;
                list.Add(new float[2] { currPos[0], currPos[1] + 0.5f });
            }
            else if (c == 'R' && currPos[0] < 5)
            {
                currPos[0]++;
                list.Add(new float[2] { currPos[0] - 0.5f, currPos[1] });
            }
            else if (c == 'L' && currPos[0] > -5)
            {
                currPos[0]--;
                list.Add(new float[2] { currPos[0] + 0.5f, currPos[1] });
            }
        }

        for (int i = 0; i < list.Count; i++)
            for (int j = i + 1; j < list.Count; j++)
                if (list[i][0] == list[j][0] && list[i][1] == list[j][1])
                    list.RemoveAt(j--);

        foreach (float[] tmp in list)
        {
            foreach (float value in tmp)
                Console.Write(value + " ");
            Console.WriteLine();    
        }

        return list.Count;
    }
}
