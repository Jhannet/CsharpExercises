namespace CsharpExercises.Exercises
{
    class Exercise7
    {
        public static string Uncensor(string txt, string vowels)
        {
            foreach (char vowel in vowels)
            {
                var index = txt.IndexOf("*");
                txt = txt.Substring(0, index) + vowel + txt.Substring(index+1);
            }
            
            return txt;
        }
    }
}
