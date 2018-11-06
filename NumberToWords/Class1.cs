using System;

namespace NumbersToWords
{
    public class Converter
    {
        public static string Convert(int number)
        {
            var word = "";
            if (number == 0)
            {
                word = "zero";
            }
            if (number == 1)
            {
                word = "one";
            }
            if (number == 2)
            {
                word = "two";
            }
            if (number == 3)
            {
                word = "three";
            }

            return word; 
        }
    }
}
