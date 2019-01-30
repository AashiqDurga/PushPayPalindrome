using System;

namespace PalindromeCheckerConsoleApp
{
    class Program
    {
        private static readonly PalindromeChecker _palindromeChecker;

        static Program()
        {
            _palindromeChecker = new PalindromeChecker();
        }

        static void Main(string[] args)
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);
        }

        private static void Check(string inputString, bool shouldBePalindrome)
        {
            Console.WriteLine(_palindromeChecker.PrintResult(inputString, shouldBePalindrome));
        }
    }
}