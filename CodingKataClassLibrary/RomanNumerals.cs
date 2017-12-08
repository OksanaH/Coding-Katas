using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingKataClassLibrary;

namespace CodingKataClassLibrary
{
    public class RomanNumerals
    {
        private char AppendCXI(int divisor)
        {
            return (divisor == 100 ? 'C' : (divisor == 10 ? 'X' : 'I'));
        }
       

        private KeyValuePair<string,int> arabicToRomanDivisor (int remainder, int divisor)
        {
            List<KeyValuePair<string, int>> values = new List<KeyValuePair<string, int>>();
            StringBuilder strNumber = new StringBuilder();
            if (remainder > 0 && remainder / divisor > 0)
            {
                //thousands
                if (divisor==1000)
                    strNumber.Append(AppendSymbols(remainder / 1000, 'M'));
                else
                {
                    if (remainder >= 5 * divisor)
                    {
                        if (remainder / divisor != 9)
                        {
                            strNumber.Append((divisor == 100 ? "D" : (divisor == 10 ? "L" : "V")));//100s - D, 10s - L 1s - V
                            strNumber.Append(AppendSymbols((remainder - 5 * divisor) / divisor, AppendCXI(divisor)));//100s C 10s X 1s- I
                        }
                        else
                            strNumber.Append((divisor == 100 ? "CM" : (divisor == 10 ? "XC" : "IX"))); //100s CM   10s XC     1s IX
                    }
                    else
                    {
                        if (remainder / divisor != 4)
                            strNumber.Append(AppendSymbols(remainder / divisor, AppendCXI(divisor)));//100s C   10s X    1s I
                        else
                            strNumber.Append((divisor == 100 ? "CD" : (divisor == 10 ? "XL" : "IV"))); //100s CD   10s XL    1sIV
                    }
                }
                remainder = remainder % divisor;
            }
            return new KeyValuePair<string, int>(strNumber.ToString(), remainder);
        }

        public string ArabicToRoman(int arabicNum)
        {
            StringBuilder result = new StringBuilder();
            int remainder = arabicNum;
            if (arabicNum != -1)
            {
                for (int i=1000; i>0; i=i/10)
                {               
                    if (remainder > 0 && remainder / i > 0)
                    {
                        result.Append(arabicToRomanDivisor(remainder, i).Key);
                        remainder = arabicToRomanDivisor(remainder, i).Value;
                    }
                }
            }
            return result.ToString();
        }
     
        private string AppendSymbols(int quantity, char symbol)
        {
            StringBuilder sb = new StringBuilder();
            return (sb.Append(symbol, quantity).ToString());
        }
    }

}
