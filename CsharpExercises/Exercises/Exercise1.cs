using System.Text;

namespace CsharpExercises
{
    class Exercise1
    {
        public static string AlphabetPosition(string text)
        {
            var result = new StringBuilder();

            foreach (char letter in text)
            {
                int asciiValue = char.ToUpper(letter);

                if (asciiValue >= 65 && asciiValue <= 90)
                {
                    result.Append((asciiValue - 64) + " ");
                }
            }

            return result.ToString().Trim();
        }
    }
}
