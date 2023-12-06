using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises.Exercises
{
    class Exercise3
    {

        /*
         * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
         * Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
         * Additionally, if the number is negative, return 0.
         * Note: If the number is a multiple of both 3 and 5, only count it once.
         */
        public static int Solution(int value)
        {
            int result = 0;

            for (int number=3; number < value; number++)
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    result += number;
                }
            }

            return result;
        }
    }
}
