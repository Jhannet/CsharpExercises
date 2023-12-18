using CsharpExercises.Exercises;
using System;

namespace CsharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Exercise1.AlphabetPosition("The sunset sets at twelve o' clock.");
            Console.WriteLine(result);

            string humanTime = Exercise2.GetReadableTime(359999);
            Console.WriteLine(humanTime);

            int sum = Exercise3.Solution(200);
            Console.WriteLine(sum);

            string camelCase = Exercise4.ToCamelCase("the-stealth-warrior");
            Console.WriteLine(camelCase);

            int duplicateCount = Exercise5.DuplicateCount("indivisibility");
            Console.WriteLine(duplicateCount);


            string oldText = Exercise7.Uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo");
            Console.WriteLine(oldText);

            int count = Exercise8.PowerRanger(4, 250, 1300);
            Console.WriteLine(count);

            bool isPalindrome = Exercise9.AlmostPalindrome("1234312");
            Console.WriteLine(isPalindrome);

            string[] strs = { "flower", "flow", "flight" };
            string longestPrefix = Exercise12.longestCommonPrefix(strs);
            Console.WriteLine(longestPrefix);

            int[] answers = { 5, 5, 10, 10, 15, 15, 20, 20 };
            string interviewResult = Exercise13.Interview(answers, 120);
            Console.WriteLine(interviewResult);

            int longestLength = Exercise6.LengthOfLongestSubstring("pwwkew");
            Console.WriteLine(longestLength);

            double[] tribonacci = Exercise10.Tribonacci(new double[] { 1, 1, 1 }, 10);
            Console.WriteLine(tribonacci.ToString());

            int maxSequence = Exercise11.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.WriteLine(maxSequence);

            int diamondSum = Exercise14.DiamondSum(3);
            Console.WriteLine(diamondSum);
        }
    }
}
