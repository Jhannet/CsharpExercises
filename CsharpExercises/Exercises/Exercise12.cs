using System.Linq;

namespace CsharpExercises.Exercises
{
    class Exercise12
    {
        public static string longestCommonPrefix(string[] strs)
        {
            var firstWord = strs[0];

            while (firstWord.Length > 0)
            {
                if (strs.All(s => s.StartsWith(firstWord)))
                {
                    break;
                }

                firstWord = firstWord.Substring(0, firstWord.Length - 1);
            }

            return firstWord;
        }
    }
}
