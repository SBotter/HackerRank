using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class PlusMinus
    {
        public void Result(List<int> arr)
        {

            double positive = 0;
            double negative = 0;
            double zero = 0;

            //array of elements
            foreach (int i in arr)
            {
                //check the positives
                if (i > 0)
                {
                    positive++;
                }
                else if(i < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }

            int sizeElements = arr.Count;

            double ratioPositive = positive/sizeElements;
            double ratioNegative = negative / sizeElements;
            double ratioZero = zero / sizeElements;

            Console.WriteLine(ratioPositive.ToString("N6"));
            Console.WriteLine(ratioNegative.ToString("N6"));
            Console.WriteLine(ratioZero.ToString("N6"));
        }
    }
}
