namespace CsharpExercises.Exercises
{
    class Exercise13
    {
        public static string Interview(int[] arr, int tot)
        {
            string result = "disqualified";
            var expectedTimes = new int[] { 5, 5, 10, 10, 15, 15, 20, 20 };

            if (arr.Length < 8)
            {
                return result;
            }

            if (tot > 120)
            {
                return result;
            }

            for (int index = 0; index < expectedTimes.Length; index++)
            {
                if (arr[index] > expectedTimes[index])
                {
                    return result;
                }
            }

            return "qualified";
        }
    }
}
