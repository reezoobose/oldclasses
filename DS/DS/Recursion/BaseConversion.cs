using System;
using System.Linq;

namespace DS.Recursion
{
    public static class BaseConversion
    {
        /// <summary>
        /// [Recursive Version]
        /// Base conversion process is a process to convert a number to decimal to binary,octal or hexadecimal.
        /// </summary>
        /// <param name="conversionUnit">for binary = 2 , octal = 8 , hexadecimal = 16</param>
        /// <param name="number">Number need to convert .</param>
        public static void BaseConversionProcess(int conversionUnit,int number)
        {
            if (conversionUnit < 0) { throw new InvalidOperationException("Conversion unit can not be negative.");}
            if (number < 0) { throw new InvalidOperationException("Please enter a positive number .");}
            if (number== 0) { return;}
            BaseConversionProcess(conversionUnit,number / conversionUnit);
            Console.WriteLine(number%conversionUnit);
        }

        /// <summary>
        /// [Iterative Version]
        /// Base conversion process is a process to convert a number to decimal to binary,octal or hexadecimal.
        /// </summary>
        /// <param name="conversionUnit">for binary = 2 , octal = 8 , hexadecimal = 16</param>
        /// <param name="number">Number need to convert .</param>
        public static string BaseConversionProcessIterative(int conversionUnit, int number)
        {
            var result = "";
            while (number != 0)
            {
                result += (number % conversionUnit).ToString();
                number = number / conversionUnit;
            }

            return result;
        }

    }
}
