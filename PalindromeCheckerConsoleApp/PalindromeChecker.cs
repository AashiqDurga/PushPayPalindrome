using System;

namespace PalindromeCheckerConsoleApp
{
    public class PalindromeChecker
    {
        public bool isPalindrome(string inputString)
        {
            var stringWithNoSpaces = inputString.Replace(" ", "");
            
            var charArray = stringWithNoSpaces.ToLower().ToCharArray();
            Array.Reverse(charArray);
            
            var palindrome = new string(charArray);

            return stringWithNoSpaces.ToLower() == palindrome;
        }
    }
}