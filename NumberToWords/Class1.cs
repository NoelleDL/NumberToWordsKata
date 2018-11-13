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
            {20, "twenty"},
            {30, "thirty"},
            {40, "forty"},
            {50, "fifty"},
            {60, "sixty"},
            {70, "seventy"},
            {80, "eighty"},
            {90, "ninety"},
            {100, "one hundred"}
        };

        public static string Convert(int number)
        {
            if (number > 20 && number < 99 && number % 10 != 0)
            {
                var ones = number % 10;
                var tens = number - ones;
                return numDictionary[tens] + "-" + numDictionary[ones];

            }

            if (number > 100 && number % 100 != 0)
            {
                var ones = number % 100;
                var hundreds = number - ones;
                return numDictionary[hundreds] + " " + numDictionary[ones];
            }
                return numDictionary[number];
           
        }

    }
}
