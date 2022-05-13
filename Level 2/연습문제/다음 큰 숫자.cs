using System;
using System.Text.RegularExpressions;

class Solution 
{
    public int solution(int n) 
   {
        int answer = 0;
        int tmp = Regex.Matches(Convert.ToString(n,2), "1").Count;
        while(true) {   
            if( tmp == Regex.Matches(Convert.ToString(++n,2), "1").Count )
                break;
        }

        return n;
    }
}
