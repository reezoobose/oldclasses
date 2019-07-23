using System;

namespace DS.Recursion
{
    public static class FibonacciSeries
    {
        /// <summary>
        /// [Recursive ]Return a fibonacci number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long FindFibonacciNumberOfTheSeries(long number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException("Number should be greater than zero.");
            }

            if (number == 0) return 0;
            if (number == 1) return 1;
            return FindFibonacciNumberOfTheSeries(number - 1) + FindFibonacciNumberOfTheSeries(number - 2);
        }

        /// <summary>
        /// [Iterative]Return a fibonacci number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long GetFibonacciNumberOfTheSeries(long number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException("Number should be greater than zero.");
            }

            long x = 0, y = 1, z = 0;
            for (var i = 0; i < number; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }

            return z;
        }
    }
}
