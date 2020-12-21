using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indicator
{
    public class SimpleIndicator
    {
        public static List<double> MovingAverage(List<double> data, int period)
        {
            List<double> output;
            if (period == 1)
            {
                output = data;
            } else
            {
                output = new List<double>();
            }
            
            return output;
        }
    }
}
