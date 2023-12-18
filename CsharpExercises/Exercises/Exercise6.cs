using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises.Exercises
{
    class Exercise6
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int res = 0;
            int n = s.Length;
            int i = 0;

            while (i < n)
            {
                bool[] visited = new bool[256];
                int j = i;
                while (j < n && !visited[s[j]])
                {
                    res = Math.Max(res, j - i + 1);
                    visited[s[j]] = true;
                    j++;
                }
                visited[s[i]] = false;
                i++;
            }

            return res;
        }

        public static int LengthOfLongestSubstring1(string s)
        {
            int n = s.Length;
            int res = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    bool areDistinct = true;
                    bool[] visited = new bool[256];

                    for (int k = i; k <= j; k++)
                    {
                        if (visited[s[k]] == true)
                        {
                            areDistinct = false;
                            break;
                        }

                        visited[s[k]] = true;
                    }

                    if (areDistinct)
                        res = Math.Max(res, j - i + 1);
                }
            }

            return res;
        }
    }
}
