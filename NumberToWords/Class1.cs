using System;
using System.Collections.Generic; 

namespace NumbersToWords
{
    public class Converter
    {
        private static Dictionary<int, string> numDictionary = new Dictionary<int, string>()
        {
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
            {20, "twenty"}
        };

        public static string Convert(int number)
        {
            if (number > 20)
            {
                var ones = number % 10;
                var tens = number - ones;
                return numDictionary[tens] + "-" + numDictionary[ones];

            }
                return numDictionary[number];
           
        }

    }
}
