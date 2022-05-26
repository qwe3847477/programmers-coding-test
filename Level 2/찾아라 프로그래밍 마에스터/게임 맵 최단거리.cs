using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
            Queue<int[]> q = new Queue<int[]>();
            q.Enqueue(new int[] { 0, 0, 1 }); // column , row , value
            int answer = 1;

            while (q.Count != 0)
            {
                int[] tmp = q.Dequeue();
                if (tmp[0] == maps.GetLength(0) - 1 &&
                    tmp[1] == maps.GetLength(1) - 1)
                    return tmp[2];
                Move(ref q, ref maps, tmp);
            }
            return -1;
        }
        public void Move(ref Queue<int[]> q, ref int[,] maps, int[] location)
        {
            int column = location[0];
            int row = location[1];
            int value = location[2];    
            if (row > 0 && maps[column, row - 1] == 1)
            {
                q.Enqueue(new int[] { column, row - 1, value + 1 });
                maps[column, row - 1] = 0;
            }
            if (row < maps.GetLength(1) - 1 && maps[column, row + 1] == 1)
            {
                q.Enqueue(new int[] { column, row + 1, value + 1 });
                maps[column, row + 1] = 0;
            }
            if (column > 0 && maps[column - 1, row] == 1)
            {
                q.Enqueue(new int[] { column - 1, row, value + 1 });   
                maps[column - 1, row] = 0;           
            }
            if (column < maps.GetLength(0) - 1 && maps[column + 1, row] == 1)
            {
                q.Enqueue(new int[] { column + 1, row, value + 1 });
                maps[column + 1, row] = 0; 
            }
        }
}
