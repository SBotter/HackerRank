using System;
using System.Collections.Generic;
using System.Text; 

namespace HackerRank
{
   public  class MatchingStrings
    {

        public List<int> Result(List<string> strings, List<string> queries)
        {

            string qry = "";
            int occurs = 0;
            List<int> sumMatching = new List<int>();

            for(int q = 0; q < queries.Count; q++)
            {
                qry = queries[q];

                for (int s = 0; s < strings.Count; s++)
                {
                    if (strings[s] == qry)
                    {
                        occurs++;
                    }
                }
                sumMatching.Add(occurs);
                occurs = 0;

            }

            return sumMatching;

        }
    }
}
