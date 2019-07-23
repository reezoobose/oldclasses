namespace DS.Recursion
{
    public static class Factorial
    {
        /// <summary>
        ///     Get factorial.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long GetFactorial(long value)
        {
            if (value == 0) return 1;
            return value * GetFactorial(value - 1);
        }

        /// <summary>
        ///     Find factorial .
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long FindFactorial(long value)
        {
            long factorial = 1;
            for (var i = value; i < 0; i--) factorial *= i;
            return factorial;
        }
    }
}