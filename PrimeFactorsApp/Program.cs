using System;
using PrimeFactorsLibrary;
namespace PrimeFactors
{
    class program
    {
        
        static void GetPrimeFactors()
        {
            bool isNumber;
            do
            {
                Console.Write("Enter a number to get its prime factors:  ");
                isNumber = int.TryParse(Console.ReadLine(), out int number);
                if (isNumber)
                {
                    // ANumbersPrimeFactors(number);
                    string primeFactorsOfANumber = PrimeFactorsCalculator.PrimeFactors(number);
                    Console.WriteLine($"Prime Factors:  {primeFactorsOfANumber}");
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number");
                }

            } while (isNumber);
        }
        public static void Main(String[] args)
        {
            GetPrimeFactors();
        }
    }
}