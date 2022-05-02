using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class LonelyInteger
    {
        public int Result(List<int> a)
        {
            int number = 0;
            a.Sort();
            List<int> numbers = a;
            int countNumber = 0;

            for(int num = 0;num < a.Count;num++)
            {
                number = a[num];

                for(int n = 0; n < numbers.Count; n++)
                {
                    if(number == numbers[n])
                    {
                        countNumber++;
                    }
                }

                if (countNumber == 1)
                {
                    return number;
                }

                countNumber = 0;
            }

            return number;
        }
    }
}
