using System.Linq;

namespace CsharpExercises.Exercises
{
    class Exercise5
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(letter => letter).Where(group => group.Count() > 1).Count();
        }
    }
}
