using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class PermutingTwoArrays
    {
        public string Result(int k, List<int> A, List<int> B)
        {

            A.Sort();
            B.Sort();

            int aIndex = 0, bIndex = B.Count -1;
            
            while(aIndex < A.Count && bIndex >= 0)
            {
                if (A[aIndex] + B[bIndex] < k) return "NO";
                aIndex++;
                bIndex--;
            }

            return "YES";



            /*
            int arraySize = A.Count;
            string validate = "NO";
            
            for(int i = 0; i < arraySize; i++)
            {
                if(A[i] + B[i] >= k)
                {
                    validate = "YES";
                }
                else
                {
                    validate = "NO";
                    break;
                }
            }

            return validate;
            */
        }
    }
}
