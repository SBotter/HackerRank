using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class xorStrings
    {
        public string Result(string s, string t)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if(s.Substring(i, 1) == t.Substring(i, 1))
                {
                    result += "0";
                }
                else
                {
                    result += "1";
                }
            }
            return result;
        }
    }
}
