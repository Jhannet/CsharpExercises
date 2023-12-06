using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises.Exercises
{
    class Exercise2
    {
        /*
         * Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
         * */
        public static string GetReadableTime(int seconds)
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
        }
    }
}
