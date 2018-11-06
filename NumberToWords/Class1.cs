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
            else 
            {
                word = "one";
            }

            return word; 
        }
    }
}
