using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace 연습용
{
    internal class Solution
    {
        List<int> list = new List<int>();

        public int solution(string numbers)
        {
            int answer = 0;
            List<char> numbers_list = numbers.ToCharArray().ToList();

            for (int size = 1; size <= numbers.Length; size++)
                Comb(numbers_list, size, 0, "");

            foreach (int i in list)
            {
                Console.Write(i + " ");
                if (IsPrime(i))
                    answer++;
            }

            Console.WriteLine();

            foreach (char i in numbers_list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            return answer;

        }

        public bool IsPrime(int n)
        {
            if (n == 0)
                return false;
            else if (n == 1)
                return false;
            else if ((n & 2) == 0)
                return false;
            else
                for (int i = 3; i < Math.Sqrt(n); i++)
                    if (n % i == 0)
                        return false;

            return true;
        }


        public void Comb(List<char> numbers_list, int size, int tmp, string sum)
        {
            if (size == tmp)
            {
                if (!list.Contains(Convert.ToInt32(sum)))
                    list.Add(Convert.ToInt32(sum));     //중복되지 않을 시 숫자 완성되면 저장
                return;                                 //앞자리 0으로 시작하는 것도 거름
            }

            for (int i = 0; i < numbers_list.Count; i++)
            {
                char c_tmp = numbers_list[i];
                List<char> tmp_list = numbers_list.GetRange(0,numbers_list.Count);
                tmp_list.RemoveAt(i);
                Comb(tmp_list, size, tmp + 1, sum + c_tmp);
            }
        }
    }
}
