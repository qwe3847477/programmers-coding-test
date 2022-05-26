using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] priorities, int location) {
            List<int[]> list = new List<int[]>();
            List<int> descending = new List<int>();
            descending = priorities.ToList();
            descending.Sort();
            descending.Reverse();
            int _return = 1;

            for (int i = 0; i < priorities.Length; i++)
                list.Add(i == location ? new int[] { priorities[i], 1 } : new int[] { priorities[i], 0 });

            while (true)
            {
                if (list[0][0] == descending[0])
                {
                    if (list[0][1] == 1)
                        return _return;
                    else
                    {
                        list.RemoveAt(0);
                        descending.RemoveAt(0);
                        _return++;
                    }
                }
                else
                {
                    list.Add(list[0]);
                    list.RemoveAt(0);
                }
            }
    }
}
