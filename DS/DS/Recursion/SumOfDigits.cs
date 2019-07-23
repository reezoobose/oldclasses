namespace DS.Recursion
{
    /// <summary>
    ///     Sum of digits .
    /// </summary>
    public static class SumOfDigits
    {
        /// <summary>
        ///     Get the sum of digits .
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int FindSumOfDigits(int number)
        {
            var lastSignificantDigit = number % 10; // Last Digit .
            var result = number / 10; // Remaining number .
            if (result == 0) return number;
            return lastSignificantDigit + FindSumOfDigits(result);
        }

        /// <summary>
        /// Iterative version of Sum of digits .
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int GetSumOgDigits(int number)
        {
            var sum = 0;
            while (number / 10 != 0)
            {
                sum += number % 10;
                number = number / 10;
            }

            return sum;
        }
    }
}