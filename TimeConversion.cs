using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class TimeConversion
    {
        public void Result(string s)
        {

            DateTime datetime = DateTime.ParseExact(s, "hh:mm:sstt", System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine(datetime.ToString("HH:mm:ss"));
        }
    }
}
