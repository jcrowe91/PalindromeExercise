using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("racetruck", false)]
        [InlineData("kayak", true)]
        [InlineData("steamboat", false)]
        public void Test1(string word, bool expected)
        {
            var WordSmith = new WordSmith();
            var actual = WordSmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
