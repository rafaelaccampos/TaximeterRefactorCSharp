using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaximeterRefactoring
{
    public class TaximeterBefore
    {
        public decimal Taxe(decimal dist, DateTime d)
        {

            //overnight 

            if(d.Hour >= 22)
            {
                return dist * 3.90m;
            }
            else
            {
                //sunday
                if(d.DayOfWeek == 0)
                {
                    return dist * 2.9m;
                } else
                {
                    return dist * 2.10m;
                }
            }
        }
    }
}
