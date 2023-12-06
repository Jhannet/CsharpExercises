namespace CsharpExercises.Exercises
{
    class Exercise4
    {
        public static string ToCamelCase(string str)
        {
            var words = str.Split(new char[2] { '-', '_' });
            var result = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                var word = words[i];
                result += char.ToUpper(word[0]) + word.Substring(1);
            }

            return result;
        }
    }
}
