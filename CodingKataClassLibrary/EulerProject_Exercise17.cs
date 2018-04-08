using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataClassLibrary
{
   // https://projecteuler.net/problem=17
    /*If the numbers 1 to 5 are written out in words: one, two, three, four, five, 
     * then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
     If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, 
     how many letters would be used?
*/
/// <summary>
/// 1-19 - array of words;
/// 10s (20, 30...90)
/// 100, 100
/// logic to work out the word for a number: if Number <20 --> get value from array
/// if Number >20 and Number <100 - get last digit, get word from array, subtract from the number,
/// get word for the 10X number
/// 
/// </summary>
    public class LettersCount
    {
        private string[] OneToTwoDigitWords = new string[]
        { "zero","one", "two","three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
          "twelve","thirteen","fourteen","fifteen","sixteen","seventeen",
          "eighteen", "nineteen"};

        private string[] Tens = new string[]
        { "","","twenty","thirty","fourty","fifty","sixty","seventy",
          "eighty", "ninety"};

        private List<KeyValuePair<int,int>>Divisors { get; set; }
        public LettersCount()
        {
           Divisors = new List<KeyValuePair<int, int>>();
           Divisors.Add(new KeyValuePair<int, int>(2, 10));
           Divisors.Add(new KeyValuePair<int, int>(3, 100));
        }
        
        public int CalculateLettersForaRange(int start, int end)
        {
            int sum = 0;
            for (int i=start; i<= end; i++)
            {
                sum += GetLettersCountInNumber(i);
            }
            if (end==1000)
            {
                sum += 8;
            }
            return sum;
        }
        public int GetLettersCountInNumber(int number)
        {
            return GetNumberInWords(number).Replace(" ", "").Replace("-", "").Length;
        }
        public string GetNumberInWords(int number)
        {
            string result = "";
            int length = number.ToString().Length;
            int divisor = Divisors.Where(d => d.Key == length)
                .Select(d => d.Value)
                .SingleOrDefault();
            if (length<=2 && number < OneToTwoDigitWords.Length)
            {
                result = OneToTwoDigitWords[number];
            }
            else
            {               
                result = GetNumber(number, divisor);
                
            }           
            
            return result;
        }

        private string GetNumber(int number, int divisor) //divisor=10 or 100
        {
            string result = "";
            try
            {
                if (number % divisor > 0)
                {
                    string lastDigit = "";
                    if (divisor == 10)
                    {
                        lastDigit = OneToTwoDigitWords[number % 10];
                        if (!String.IsNullOrEmpty(lastDigit))
                        {
                            result = Tens[number / 10] + (number / 10 > 0 ? "-" : "") + lastDigit;
                        }
                        else
                        {
                            result = Tens[number / 10];
                        }
                    }
                    if (divisor == 100)
                    {
                        result = GetNumber(number % 100, 10);
                        result = OneToTwoDigitWords[number / 100] + " hundred and " + result;
                    }

                }
                else
                {
                    if (divisor == 10)
                    {
                        result = Tens[number / 10];
                    }
                    else
                    {
                        result = OneToTwoDigitWords[number / 100] + " hundred";
                    }

                }
            }
            catch (Exception ex)
            {

            }
            
            
            return result;
        }
    }   

}
