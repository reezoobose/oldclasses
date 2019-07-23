namespace DS.Recursion
{
    public static class GreatestCommonDivisor
    {
        /// <summary>
        ///     Greatest Common divisor.
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns></returns>
        public static int FindGreatestCommonDivisor(int numberOne, int numberTwo)
        {
            return numberTwo == 0 ? numberOne : FindGreatestCommonDivisor(numberTwo, numberOne % numberTwo);
        }
    }
}