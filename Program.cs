using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {

            var plusMinus = new PlusMinus();
            //List<long> arr = new List<long>(new long[] { 7, 69, 2, 221, 8974 });
            //plusMinus.Result(arr);

            var miniMaxSum = new MiniMaxSum();
            //miniMaxSum.Result(arr);

            var timeConversion = new TimeConversion();
            //string s = "07:05:45PM";
            //timeConversion.Result(s);

            var matchingStrings = new MatchingStrings();
            //List<string> strings = new List<string>(new string[] { " ab", " ab", " abc" });
            //List<string> queries = new List<string>(new string[] { " ab", " abc", "bc" });
            //matchingStrings.Result(strings, queries);

            var lonelyInteger = new LonelyInteger();
            //List<int> listOfNumbers = new List<int>(new int[] { 1, 2, 3, 4, 3, 2, 1 });
            //lonelyInteger.Result(listOfNumbers);

            var diagonalDifference = new DiagonalDifference();
            /*
            List<List<int>> listOfNumbers = new List<List<int>>
                {   new List<int>(){   6,  6,   7, -10,  9, -3,  8,  9, -1 },
                    new List<int>(){   9,  7, -10,   6,  4,  1,  6,  1,  1 },
                    new List<int>(){  -1, -2,   4,  -6,  1, -4, -6,  3,  9 },
                    new List<int>(){  -8,  7,   6,  -1, -6, -6,  6, -7,  2 },
                    new List<int>(){ -10, -4,   9,   1, -7,  8, -5,  3, -5 },
                    new List<int>(){  -8, -3,  -4,   2, -3,  7, -5,  1, -5 },
                    new List<int>(){  -2, -7,  -4,   8,  3, -1,  8,  2,  3 },
                    new List<int>(){  -3,  4,   6,  -7, -7, -8, -3,  9, -6 },
                    new List<int>(){  -2,  0,   5,   4,  4,  4, -3,  3,  0 }
                };

            diagonalDifference.Result(listOfNumbers);
            */
            var countingSort = new CountingSort();
            //List<int> numbers = new List<int>(new int[] { 63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30, 27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33 });
            //countingSort.result(numbers);

            var paragram = new Paragram();
            //string s = "The quick brown fox Jumps ovEr the lAzy doG";
            //string s = "We promptly judge antique ivory buckles for the prize";

            //paragram.result(s);

            var permutingTwoArrays = new PermutingTwoArrays();
            //int K = 5;
            //List<int> A = new List<int>(new int[] { 1, 2, 2, 1 });
            //List<int> B = new List<int>(new int[] { 3, 3, 3, 4 });
            //permutingTwoArrays.Result(K, A, B);

            var fizzBuzz = new FizzBuzz();
            //int n = 15;
            //fizzBuzz.Result(n);

            var subArrayDivision = new SubArrayDivision();
            //List<int> s = new List<int>(new int[] { 4, 5, 4, 5, 1, 2, 1, 4, 3, 2, 4, 4, 3, 5, 2, 2, 5, 4, 3, 2, 3, 5, 2, 1, 5, 2, 3, 1, 2, 3, 3, 1, 2, 5 });
            //List<int> s = new List<int>(new int[] { 4, 5, 4, 2, 4, 5, 2, 3, 2, 1, 1, 5, 4 });
            //int d = 15;
            //int m = 4;

            List<int> s = new List<int>(new int[] { 1, 2, 1, 3, 2 });
            int d = 3;
            int m = 2;

            subArrayDivision.Result(s, d, m);




        }
    }
}
