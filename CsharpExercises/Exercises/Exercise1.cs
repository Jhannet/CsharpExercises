using System.Text;
using System.Linq;
using System;

namespace CsharpExercises
{
    class Exercise1
    {
        public static string AlphabetPosition(string text)
        {
            /*var result = new StringBuilder();

            var query = from c in text
                        where c >= 65 && c <= 90
                        select c - 64;*/
            int count = 0;
            var groups = text.GroupBy(x => x);
            foreach (var group in groups)
            {
                Console.WriteLine(group.Key + " " + group.Count());
                count += group.Count()/2;
            }
            return count.ToString();
            //return string.Join(" ", text.ToUpper().Where(x => x >= 65 && x <= 90).Select(x => x - 64));

            /*foreach (char letter in text)
            {
                int asciiValue = char.ToUpper(letter);

                if (asciiValue >= 65 && asciiValue <= 90)
                {
                    result.Append((asciiValue - 64) + " ");
                }
            }

            return result.ToString().Trim();*/
        }
    }
}
