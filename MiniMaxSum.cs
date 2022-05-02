using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class MiniMaxSum
    {
        public void Result(List<long> arr)
        {
            long minSum = 0;
            long maxSum = 0;

            //sort off the list of numbers for minimum sum
            arr.Sort();
            for (int i = 0; i <= 3; i++)
            {
                minSum += arr[i];
            }

            arr.Reverse();
            for (int i = 0; i <= 3; i++)
            {
                maxSum += arr[i];
            }
            Console.WriteLine(minSum + " " + maxSum);

        }

    }
}
