using System;
using System.Text;

namespace PrimeFactorsLibrary
{
    public class PrimeFactorsCalculator
    {
        public static string PrimeFactors(int number)
        {
            StringBuilder result = new StringBuilder();

            if (number <= 1)
            {
                result.Append("Prime factors are not defined for numbers less than 2.");
                return result.ToString();
            }

            int divisor = 2;

            while (number > 1)
            {
                if (number % divisor == 0)
                {
                    result.Append(divisor);

                    if (number != divisor)
                    {
                        result.Append(" * ");
                    }

                    number /= divisor;
                }
                else
                {
                    divisor++;
                }
            }

            return result.ToString();
        }
    }
}
