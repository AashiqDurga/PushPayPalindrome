using Xunit;

namespace PalindromeChecker.Tests
{
    public class PalindromeCheckerTests
    {
        [Theory]
        [InlineData("abcba", true)]
        [InlineData("abcde", false)]
        [InlineData("Mr owl ate my metal worm", true)]
        [InlineData("Never Odd Or Even", true)]
        [InlineData("Never Even Or Odd", false)]
        public void GivenStringCheckIfItIsAPalindrome(string input, bool expected)
        {

            var palindromeChecker = new PalindromeCheckerConsoleApp.PalindromeChecker();
            var result = palindromeChecker.isPalindrome(input);

            Assert.Equal(expected,result);
        }
    }
}