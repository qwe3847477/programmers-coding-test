using System;

public class Solution {
    public int solution(int[,] sizes) {
            int Vertical = 0;
            int Horizontal = 0;

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                if (sizes[i, 0] < sizes[i, 1])
                {
                    if (Vertical < sizes[i, 1])
                        Vertical = sizes[i, 1];
                    if(Horizontal<sizes[i,0])
                        Horizontal = sizes[i, 0];
                }
                else
                {
                    if (Vertical < sizes[i, 0])
                        Vertical = sizes[i, 0];
                    if (Horizontal < sizes[i, 1])
                        Horizontal = sizes[i, 1];
                }
            }
            return Vertical * Horizontal;
    }
}
