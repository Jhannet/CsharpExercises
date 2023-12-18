using System.Linq;

namespace CsharpExercises.Exercises
{
    class Exercise10
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
                return new double[0];

            if (n < 3)
                return signature.Take(n).ToArray();

            double[] res = new double[n];
            res[0] = signature[0];
            res[1] = signature[1];
            res[2] = signature[2];

            for (int i=3; i<n; i++)
            {
                res[i] = res[i-1] + res[i-2] + res[i-3];
            }

            return res;
        }
    }
}
