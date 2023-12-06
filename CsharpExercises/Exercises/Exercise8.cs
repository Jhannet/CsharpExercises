using System;

namespace CsharpExercises.Exercises
{
    class Exercise8
    {
        public static int PowerRanger(int power, int min, int max)
        {
            double powResult = 0;
            int number = 1;
            int count = 0;

            while (powResult < max)
            {
                powResult = Math.Pow(number, power);

                if (powResult >= min && powResult <= max)
                {
                    count++;
                }

                number++;
            }

            return count;
        }
    }
}
