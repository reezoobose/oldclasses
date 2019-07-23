namespace DS.Recursion
{
    public static class Power
    {
        /// <summary>
        /// [Recursive]Find the power of a number .
        /// </summary>
        /// <param name="number"></param>
        /// <param name="toThePower"></param>
        /// <returns></returns>
        public static int FindPower(int number, int toThePower)
        {
            if (toThePower == 0) { return 1 ;}

            return number * FindPower(number, toThePower - 1);
        }

        /// <summary>
        /// [Iterative]Find the power of a number .
        /// </summary>
        /// <param name="number"></param>
        /// <param name="toThePower"></param>
        /// <returns></returns>
        public static int GetPower(int number, int toThePower)
        {
            var temp = number;
            for (var i = 0; i < toThePower; i++)
            {
                temp *= number;
            }

            return temp;
        }

    }
}
