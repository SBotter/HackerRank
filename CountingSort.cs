using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
   /*public class ListOfNumbers
    {
        public int _number { get; set; }
        public int _countRepeted { get; set; }
    }
   */
    
    public class CountingSort
    {
        public int number { get; set; }
        public int countRepeted { get; set; }

        public List<int> result(List<int> arr)
        {

            List<int> response = new List<int>();
            int[] res = new int[100];
            
            foreach (int i in arr)
            {
                res[i]++;
            }
            foreach (int r in res)
            {
                response.Add(r);
            //    Console.WriteLine("{0} ", r);
            }



            /*
            
            List<CountingSort> listOfNumbers = new List<CountingSort>();
            List<int> originalListOfNumbers = arr.OrderBy(a => a).ToList();
            List<int> response = new List<int>();

            int number = originalListOfNumbers[0];
            int countRepeted = 0;


            for(int i = 0; i < originalListOfNumbers.Count; i++)
            {
                
                if(i == 0)
                {
                    //countRepeted++;
                    listOfNumbers.Add(new CountingSort() { number = number, countRepeted = countRepeted });
                }
                else
                {
                    if(number == originalListOfNumbers[i])
                    {
                        countRepeted++;
                        var updateCount = from upd in listOfNumbers
                                          where upd.number == number select upd;
                        updateCount.First().countRepeted = countRepeted;

                    }
                    else
                    {
                        countRepeted = 0;
                        listOfNumbers.Add(new CountingSort() { number = originalListOfNumbers[i], countRepeted = countRepeted });
                    }
                }
                number = originalListOfNumbers[i];
            }

            int c = -1;
            foreach(int item in arr)
            {
                var itemArr = from i in listOfNumbers
                              where i.number == item
                              select i;
                response.Add(itemArr.First().countRepeted);

            }
            
            foreach(CountingSort item in listOfNumbers)
            {
                Console.WriteLine(item.number + " - " + item.countRepeted);
            }

            */

            return response;
        }
    }
}
