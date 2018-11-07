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
        public void ReturnsThreeWhenGiven3()
        {
            int number = 3;
            string word = Converter.Convert(number);
            Assert.Equal("three", word);
        }
        [Fact]
        public void ReturnsFourWhenGiven4()
        {
            int number = 4;
            string word = Converter.Convert(number);
            Assert.Equal("four", word);
        }
    }
}
