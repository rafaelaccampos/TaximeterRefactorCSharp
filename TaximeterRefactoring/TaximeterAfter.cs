using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaximeterRefactoring
{
    public class TaximeterAfter
    {
        private const decimal OVERNIGHT_RATE = 3.90m;
        private const decimal SUNDAY_RATE = 2.9m;
        private const decimal NORMAL_RATE = 2.10m;
        public decimal GetRate(decimal distance, DateTime date)
        {
            if(IsOvernight(date))
            {
                return distance * OVERNIGHT_RATE;
            }

            if(IsSunday(date))
            {
                return distance * SUNDAY_RATE;
            }
            
            return distance * NORMAL_RATE;
        }

        private bool IsOvernight(DateTime date)
        {
            return date.Hour >= 22;
        }        
        
        private bool IsSunday(DateTime date)
        {
            return date.DayOfWeek == 0;
        }
    }
}
