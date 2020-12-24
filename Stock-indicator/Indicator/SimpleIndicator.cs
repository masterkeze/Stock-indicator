using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indicator
{
    public class SimpleIndicator
    {
        public const double EMPTY_NUMBER = -9999;
        public static List<double> MovingAverage(List<double> data, int period)
        {
            if (period <= 0)
            {
                throw new ArgumentException("You passed in a non-positive period","period");
            }
            List<double> output = new List<double>();
            double netSum = 0;
            for (int i = 0; i < data.Count; i++)
            {
                netSum += data[i];
                if (i + 1 < period)
                {
                    output.Add(EMPTY_NUMBER);
                }
                else
                {
                    if (i >= period)
                    {
                        netSum -= data[i - period];
                    }
                    output.Add(netSum / period);
                }
            }

            return output;
        }
    }
}
