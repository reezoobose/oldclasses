using System;

namespace DS.Recursion
{
    internal class PrintNumber
    {
        /// <summary>
        ///     Print number.
        /// </summary>
        /// <param name="number"></param>
        public void Print(int number)
        {
            if (number == 0) return;
            Print(number - 1);
            Console.WriteLine(number);
        }

        /// <summary>
        ///     Print decreasing order.
        /// </summary>
        /// <param name="number"></param>
        public void PrintDecreasingOrder(int number)
        {
            if (number == 0) return;
            Console.WriteLine(number);
            PrintDecreasingOrder(number - 1);
        }
    }
}