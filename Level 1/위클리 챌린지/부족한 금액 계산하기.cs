using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
            long TotalPrice = 0;
            for (int i = 1; i <= count; i++)
                TotalPrice += i * price;

            return TotalPrice - money > 0 ? TotalPrice - money : 0;
    }
}
