using System;
using Xunit;

namespace PalindromeChecker.Tests
{
    public class PalindromeCheckerTests
    {
        [Theory]
        [InlineData("abcba", true)]
        [InlineData("abcde", false)]
        public void GivenStringCheckIfItIsAPalindrome(string input, bool expected)
        {

            var palindromeChecker = new PalindromeChecker();
            var result = palindromeChecker.isPalindrome(input);

            Assert.Equal(expected,result);
        }
    }

    public class PalindromeChecker
    {
        public bool isPalindrome(string inputString)
        {
            char[] charArray = inputString.ToLower().ToCharArray();
            Array.Reverse(charArray);
            var palindrome = new string(charArray);

            if (inputString.ToLower() == palindrome)
            {
                return true;
            }

            return false;
        }
    }
}