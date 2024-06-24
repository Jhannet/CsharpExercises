using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises.Exercises
{
    class Exercise16
    {
        public static bool IsPangram(string str)
        {
            return str.ToLower().Where(character => character >= 'a' && character <= 'z').GroupBy(character => character).Count() == 26;
        }
    }
}
