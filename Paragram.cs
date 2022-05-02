using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class Paragram
    {
        public string result(string s)
        {
            int charPosition;

            List<char> alphabet = new List<char>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' });

            foreach (char i in alphabet)
            {
                charPosition = s.ToLower().IndexOf(i);

                if (charPosition < 0)
                {
                    return "not pangram";
                }
            }

            return "pangram";
        }
    }
}
