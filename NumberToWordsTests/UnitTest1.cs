using System;
using Xunit;
using NumbersToWords;

namespace NumberToWordsTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsZeroWhenGiven0()
        {
            int number = 0;
            string word = Converter.Convert(number);
            Assert.Equal("zero", word);
        }

        [Fact]
        public void ReturnsOneWhenGiven1()
        {
            int number = 1;
            string word = Converter.Convert(number);
            Assert.Equal("one", word);
        }

        [Fact]
        public void ReturnsTwoWhenGiven2()
        {
            int number = 2;
            string word = Converter.Convert(number);
            Assert.Equal("two", word); 
        }

        [Fact]
        public void ReturnsTwoWhenGiven3()
        {
            int number = 3;
            string word = Converter.Convert(number);
            Assert.Equal("three", word);
        }
    }
}
