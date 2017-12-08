using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataClassLibrary
{
    public class SundaysCalculator
    {
        private DateTime StartDate { get { return Convert.ToDateTime("01/01/1900"); } }
        private DateTime EndDate { get { return Convert.ToDateTime("31/12/1999"); } }

        public SundaysCalculator()
        {

        }
        public int CalculateSundaysLastCentury()
        {
            int sundaysCount = 0;
            DateTime startDate = this.StartDate;
            DateTime endDate = this.EndDate;
            DateTime nextDate =startDate;
            while (nextDate <= endDate)
            {
                //next date is always monday
                nextDate = nextDate.AddDays(7);
                if (nextDate.AddDays(-1).Day==1)
                {
                    sundaysCount++;
                }
            }

            return sundaysCount;

        }
    }
    

}
