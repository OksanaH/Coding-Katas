using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataClassLibrary
{
    public class PalindromeFinder
    {
        public int NumberOfDigits;
        public int SmallestNumber { get; set ; }
        public int LargestNumber { get; set; }

        public PalindromeFinder(int numberOfDigits)
        {
            this.NumberOfDigits = numberOfDigits;
            GetSmallestNumber();
            GetLargestNumber();
        }
        public bool IsPalindrome(int number)
        {
            char[] charArray = number.ToString().ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            return (reversed == number.ToString());
        }
        public void GetSmallestNumber ()
        {
            int number = 0;
            while ((Math.Floor(Math.Log10(number) + 1)) < this.NumberOfDigits)
            {
                number++;
            }
           this.SmallestNumber =  number;
        }

        public void GetLargestNumber()
        {
            int number = 0;
            while ((Math.Floor(Math.Log10(number) + 1)) < this.NumberOfDigits+1)
            {
                number++;
            }
            this.LargestNumber = number-1;
        }

        public int GetLargestPalindrome()
        {
            int largestPalindrome = 0;
            for (int i = this.LargestNumber; i>=this.SmallestNumber; i--)
            {
                for (int j = this.LargestNumber; j>=this.SmallestNumber; j--)
                {
                    if (IsPalindrome(i * j) && (i*j>largestPalindrome))
                    {
                        largestPalindrome = i * j;
                        break;
                    }
                       
                }
            }
            return largestPalindrome;
        }
    }  
}
