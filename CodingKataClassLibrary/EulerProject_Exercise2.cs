using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataClassLibrary
{
    public class PrimeFactorFinder
    {
        public int TargetNumber { get; set; }
        //private int TargetNumber1 { get; set; }
        private int?[] PrimeFactorsArray { get; set; } //= new int? [] { TargetNumber }; //auto property initialiser

        public int?[] _PrimeFactorsArray
        {
            get { return PrimeFactorsArray; }
            set { PrimeFactorsArray = new int?[] { TargetNumber }; }
        }
        public PrimeFactorFinder()
        {
            PrimeFactorsArray = _PrimeFactorsArray;
        }

        public void SetTargetNumber(int targetNumber)
        {
            TargetNumber = targetNumber;
            GetPrimeFactors();
        }
        public void GetPrimeFactors()
        {
            int arrayElementsCount = 0;
            for (int i = 1; i < TargetNumber; i++)
            {
                if (IsPrimeFactor(i))
                {
                    PrimeFactorsArray[arrayElementsCount] = i;
                    arrayElementsCount++;
                }
            }
            PrimeFactorsArray = PrimeFactorsArray.Where(n => n != (int?)null).ToArray();
        }
        public bool IsPrimeFactor(int number)
        {
            bool isPrimeFactor = false;
            for (int i = 2; i <= number; i++)
            {

                if (number % i == 0 && i < number)
                {
                    break;
                }
                if (i == number)
                {
                    return true;
                }
            }
            return isPrimeFactor;
        }

        public bool ResultOfDivisionEqualsToZero(int divisor)
        {
            if (this.TargetNumber % divisor == 0)
                return true;
            else
                return false;

        }
        public int GetLargestPrimeFactor()
        {
            int largestPrimeFactor = 3;

            return largestPrimeFactor;
        }
    }



    public class Multiplicator
    {
        public int NumberOfFactors { get; set; }
        public int[] FactorValues { get; set; }
        // public int Result { get; set; }

        public Multiplicator(int numberOfFactors)
        {
            this.NumberOfFactors = numberOfFactors;
            // this.FactorValues = factorValues;


        }
        public int Multiply(int[] factorValues)
        {
            int result = 1;
            for (int i = 0; i < this.NumberOfFactors; i++)
            {
                if (factorValues[i] > 0)
                {
                    result = result * factorValues[i];
                }
            }
            return result;
        }
    }
}


