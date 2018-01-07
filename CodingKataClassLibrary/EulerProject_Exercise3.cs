using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataClassLibrary
{
    public class PrimeNumberFinder
    {
        //the number we need to find the highest prime number for
        public long TargetNumber { get; set; }
        public long? LargestPrimeNumber { get; set; }
        private long[] PrimeNumbersArray { get; set; }


        public PrimeNumberFinder()
        {
        }

        public void SetTargetNumber(long targetNumber)
        {
            TargetNumber = targetNumber;
            GetLargestPrimeNumber();
        }

        public void GetLargestPrimeNumber()
        {
            PrimeNumbersArray = new long[TargetNumber];
            int arrayElementsCount = 0;
            for (long i = 1; i < TargetNumber; i++)
            {
                if (IsPrimeNumber(i))
                {
                    PrimeNumbersArray[arrayElementsCount] = i;
                    arrayElementsCount++;
                }
            }            
            LargestPrimeNumber =GetLargestPrimeNumber(PrimeNumbersArray, TargetNumber);

        }

        public bool IsPrimeNumber(long number)
        {
            bool isPrimeNumber = false;
            for (int divisor = 2; divisor < number; divisor++)
            {

                if (number % divisor == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
                else
                {
                    isPrimeNumber = true;
                }
            }
            return isPrimeNumber;
        }

        public long? GetLargestPrimeNumber(long[] factorValues, long targetNumber)
        {
            factorValues = factorValues.Where(v => v > 0).ToArray();
            int maxFactorValueIndex = factorValues.ToList().IndexOf(factorValues.Max());
            long? maxPrimeNumber = 1;
            for (int i = factorValues.Length - 1; i > 0; i--)
            {
                if (targetNumber % factorValues[i] == 0)
                {
                    maxPrimeNumber = factorValues[i];
                    break;
                }
            }
            return maxPrimeNumber;
        }
    }



    public class Multiplicator
    {
       
        public Multiplicator()
        {

        }
        
    }
}


