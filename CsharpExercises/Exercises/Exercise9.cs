﻿using System.Linq;

namespace CsharpExercises.Exercises
{
    class Exercise9
    {
        public static bool AlmostPalindrome(string str)
        {
            var array = str.ToArray();
            var reverseArray = array.Reverse().ToArray();
            int counter = 0;

            for (int i=0; i <= array.Length / 2; i++)
            {
                if (!array[i].Equals(reverseArray[i]))
                {
                    counter++;
                }

                if (counter > 1)
                {
                    break;
                }
            }

            return counter == 1;
        }
    }
}
