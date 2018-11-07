using System;

namespace NumbersToWords
{
    public class Converter
    {
        public static string Convert(int number)
        {
            var word = "";
            switch (number)
            {
                case 0:
                    word = "zero";
                    break; 
                case 1: 
                    word = "one";
                    break;
                case 2:
                    word = "two";
                    break; 
                case 3: 
                    word = "three";
                    break; 
                case 4:
                    word = "four";
                    break; 
                default:
                    word = "this is not a number";
                    break;
            }

            return word; 
        }
    }
}
