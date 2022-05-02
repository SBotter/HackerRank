using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class SubArrayDivision
    {
        public int Result(List<int> s, int d, int m)
        {
            int count = 0;
            
            for(int i = 0; i < s.Count; i++)
            {
                int sum = 0;
                for(int j = i; j < m+i; j++)
                {
                    if (j == s.Count) break;
                    sum = sum + s[j];
                }
                if (sum == d) count++;
            }
            
            Console.WriteLine(count);
            return count;
        }
    }
}
