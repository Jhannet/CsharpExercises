namespace CsharpExercises.Exercises
{
    class Exercise11
    {
        public static int MaxSequence(int[] arr)
        {
            int maxSequenceSum = 0;
            int currentMaxValue = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentMaxValue = currentMaxValue + arr[i];

                if (maxSequenceSum < currentMaxValue)
                    maxSequenceSum = currentMaxValue;

                if (currentMaxValue < 0)
                    currentMaxValue = 0;
            }

            return maxSequenceSum;
        }
    }
}
