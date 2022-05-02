using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class DiagonalDifference
    {
        public int Result(List<List<int>> arr)
        {
            int rigthToLeft = 0;
            int leftToRight = 0;
            
            List<int> lineArr = new List<int>();

            for(int i = 0; i< arr.Count;i++)
            {
                lineArr = arr[i];
                
                for(int n = 0; n < arr[i].Count; n++)
                {
                    if(i == 0)
                    {
                        rigthToLeft += arr[i][n];
                        break;
                    }
                    else
                    {
                        rigthToLeft += arr[i][n + i];
                        break;
                    }

                }
            }

            arr.Reverse();

            for (int i = 0; i < arr.Count; i++)
            {
                lineArr = arr[i];

                for (int n = 0; n < arr[i].Count; n++)
                {
                    if (i == 0)
                    {
                        leftToRight += arr[i][n];
                        break;
                    }
                    else
                    {
                        leftToRight += arr[i][n + i];
                        break;
                    }

                }
            }

            return Math.Abs(leftToRight - rigthToLeft);
        }
    }
}
