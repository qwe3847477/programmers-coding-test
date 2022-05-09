using System;

public class Solution 
{
    int ans,tar;
    
    public int solution(int[] numbers, int target) 
    {
        ans = 0;
        tar = target;
        Searching(0,0,numbers);
        return ans;
    }
    
    public void Searching(int sum,int i,int[]numbers)
    {
        if(i<numbers.Length)
        {
            Searching(sum + numbers[i],i+1,numbers);
            Searching(sum - numbers[i],i+1,numbers);
        }
        else if(tar == sum)
            ans++;
    }
    
}
