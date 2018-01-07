using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataClassLibrary
{
    //https://projecteuler.net/problem=5
    public class SmallestMultipleFinder
    {
        public int[] Range { get; set; }   
           

        public SmallestMultipleFinder(int[] range)
        {
            this.Range = range;
        }
        public int FindSmallestMultiple()
        {
            int starting = Range[1]+1;
            int smallestMultiple = 0;
            while (smallestMultiple==0)
            {
                if (CanBeMultipliedByAllNumbersInRange(starting))
                {
                    smallestMultiple = starting;
                }
                starting++;
            }
            return smallestMultiple;
        }

        public bool CanBeMultipliedByAllNumbersInRange(int number)
        {
            bool isMultipliableByAllNumbers = false;
            for (int i = Range[0]; i <= Range[1]; i++)
            {
                if (number ==2520)
                {

                }
                if (number % i !=0)
                {
                    isMultipliableByAllNumbers = false;
                    break;
                }
                else
                {
                    isMultipliableByAllNumbers = true;
                }

            }
            return isMultipliableByAllNumbers;
        }
       
    }
    

}
