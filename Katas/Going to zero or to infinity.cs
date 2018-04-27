namespace Katas
{
    using System;

    public class Going_to_zero_or_to_infinity
    {
        public static double going(int n)
        {
            var factorialOfN = Factorial(n);
            var fraction = 1.0 / factorialOfN;

            var multiply = GetSumOfFactorial(n - 1);
            multiply += factorialOfN;
            return Math.Round(fraction * multiply, 6);
        }

        private static double Factorial(int n)
        {
            if (n < 2)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        private static double GetSumOfFactorial(int n)
        {
            var results = 0.0;
            for (; n > 0; n--)
            {
                results += Factorial(n);
            }

            return results;
        }

        public static double TruncateDouble(double value, int precision)
        {
            var step = Math.Pow(10, precision);
            var tmp = Math.Truncate(step * value);
            return tmp / step;
        }
    }
}