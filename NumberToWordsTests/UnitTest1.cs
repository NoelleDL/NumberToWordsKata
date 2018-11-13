using System;
using Xunit;
using NumbersToWords;

namespace NumberToWordsTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "one")]
        [InlineData(2, "two")]
        [InlineData(3, "three")]
        [InlineData(4, "four")]
        [InlineData(5, "five")]
        [InlineData(6, "six")]
        [InlineData(7, "seven")]
        [InlineData(8, "eight")]
        [InlineData(9, "nine")]
        [InlineData(10, "ten")]
        [InlineData(11, "eleven")]
        [InlineData(12, "twelve")]
        [InlineData(13, "thirteen")]
        [InlineData(14, "fourteen")]
        [InlineData(15, "fifteen")]
        [InlineData(16, "sixteen")]
        [InlineData(17, "seventeen")]
        [InlineData(18, "eighteen")]
        [InlineData(19, "nineteen")]
        [InlineData(20, "twenty")]
        [InlineData(21, "twenty-one")]
        [InlineData(40, "forty")]
        [InlineData(67, "sixty-seven")]
        [InlineData(100, "one hundred")]
        [InlineData(101, "one hundred one")]
        public void ReturnsWordWhenGivenNumber(int number, string expected)
        {
            string word = Converter.Convert(number);
            Assert.Equal(word, expected);
        }
    }
}
