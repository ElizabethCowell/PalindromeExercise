using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("racecar", true)]
        [InlineData ("rainbowcat", false)]
        [InlineData ("tacocat", true)]
        public void Palindrome(string testWord, bool expected)
        {
            //Arrage
            var wordSmith = new WordSmith();
            //Act
            var actual = wordSmith.IsAPalindrome(testWord);
            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
