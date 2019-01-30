using System;

namespace PalindromeCheckerConsoleApp
{
    public class PalindromeChecker
    {
        public bool isPalindrome(string inputString)
        {
            var stringWithNoSpaces = inputString.Replace(" ", "");
            
            var palindrome = ReverseString(stringWithNoSpaces);

            return stringWithNoSpaces.ToLower() == palindrome;
        }

        public string PrintResult(string inputString, bool shouldBePalindrome)
        {
            var result = isPalindrome(inputString) == shouldBePalindrome ? "pass" : "FAIL";
            return result;
        }
        
        private static string ReverseString(string stringWithNoSpaces)
        {
            var charArray = stringWithNoSpaces.ToLower().ToCharArray();
            Array.Reverse(charArray);

            var palindrome = new string(charArray);
            return palindrome;
        }
    }
}