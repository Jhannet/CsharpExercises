using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises.Exercises
{
    class Exercise14
    {
        public static int DiamondSum(int n)
        {
            int sum = 0;
            var columnIndex = (int)(n / 2);
            var counter = columnIndex * 3;
            var distance = 3;

            var matrix = new int[n, n];

            for (var i=0; i<n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (i < 1)
                        matrix[i,j] = j + 1;
                    else
                        matrix[i, j] = matrix[i-1, n-1] + j + 1;
                }
            }

            for (var i = 0; i < n; i++)
            {
                // Include space
                //this.space(counter);
                // Display element
                sum = matrix[i, columnIndex];

                if (i < (int)(n / 2))
                {
                    counter -= distance;
                    columnIndex--;
                }
                else
                {
                    columnIndex++;
                    counter += distance;
                }
            }

            return 0;
        }
    }
}
