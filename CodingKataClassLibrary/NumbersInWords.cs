using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataClassLibrary
{

    public class NumbersToWordsConverter
    {
        private string Suffix10To19 = "teen";
        private string Suffix20To90 = "ty";

        public string ConvertNumber(int number)
        {
            string result = "";
            
            int howManyDigits = number.ToString().Length;        
            char currentChar = number.ToString()[howManyDigits-1];
            int currentDigit = int.Parse(currentChar.ToString());
                result = GetSingleDigit(int.Parse(currentChar.ToString()));
            
            if (number - currentDigit == 10)
                    {
                        if (number<14 && number>10)
                        {
                            if (number == 11)
                                result = "eleven";
                            if (number == 12)
                                result = "twelve";
                            if (number == 13)
                                result = "thirteen";
                        }
                        else
                        {
                            result = GetSingleDigit(number - 10)+Suffix10To19;
                           
                        }
                    }
            if ((number - currentDigit) % 10==0)
            {
                int[] exceptions = new int[] { 20, 30, 50 };
                if (exceptions.Contains(number - currentDigit))
                {
                    if (number - currentDigit == 20)
                        result = "twenty-" + result;
                    if (number - currentDigit == 30)
                        result = "thirty-" + result;
                    if (number - currentDigit == 50)
                        result = "fifty-" + result;

                }
                else
                {
                    result = GetSingleDigit((number - currentDigit) / 10) + Suffix20To90 +"-"+result ;

                }
            }
         



            return result;
        }
       
        private string GetSingleDigit(int number)
        {
            string result = "";
            
                if (number == 0)
                    result = "zero";
                if (number == 1)
                    result = "one";
                if (number == 2)
                    result = "two";
                if (number == 3)
                    result = "three";
                if (number == 4)
                    result = "four";
                if (number == 5)
                    result = "five";
                if (number == 6)
                    result = "six";
                if (number == 7)
                    result = "seven";
                if (number == 8)
                    result = "eight";
                if (number == 9)
                    result = "nine";
          
            
            return result;
        }
    }
}
