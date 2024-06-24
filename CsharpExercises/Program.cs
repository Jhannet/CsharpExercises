using CsharpExercises.Exercises;
using CsharpExercises.Exercises.Exercise15;
using CsharpExercises.Exercises.LinqExercise;
using System;
using System.Collections;
using System.Linq;

namespace CsharpExercises
{
    class Program
    {
        static String location;
        static DateTime time;

        static void Main(string[] args)
        {
            #region interview
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
            #endregion

            /*string result = Exercise1.AlphabetPosition("ABABC");
            Console.WriteLine(result);

            string result1 = Exercise1.AlphabetPosition("CABBACCC");
            Console.WriteLine(result1);*/

            /*string humanTime = Exercise2.GetReadableTime(359999);
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

            var paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            var paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
            var paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

            var student1 = new Student();
            var student2 = new Student();

            Console.WriteLine(string.Join("\n", student1.TestsTaken));//➞ { "No tests taken" }
            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
            Console.WriteLine(string.Join("\n", student1.TestsTaken));// ➞ { "Maths: Passed! (80%)" }

            student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
            student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
            Console.WriteLine(string.Join("\n", student2.TestsTaken));// ➞ { "Chemistry: Failed! (25%)", "Computing: Failed! (43%)" }*/

            /*var startingDeck = from s in CardDeck.Suits()
                               from r in CardDeck.Ranks()
                               select new { Suit = s, Rank = r };*/
            //var startingDeck = CardDeck.Suits().SelectMany(suit => CardDeck.Ranks().Select(rank => new { Suit = suit, Rank = rank }));

            // Display each card that we've generated and placed in startingDeck in the console
            /*foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);

            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }*/

            bool isPangram = Exercise16.IsPangram("The quick brown fox jumps over the lazy dog.");
            Console.WriteLine(isPangram);
        }
    }
}
