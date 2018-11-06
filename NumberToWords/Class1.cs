using System;

namespace NumbersToWords
{
    public class Converter
    {
        public static string Convert(int number)
        {
            //number = 0;
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
                default:
                    word = "this is not a number";
                    break;
            }

            return word; 
        }
    }
}
