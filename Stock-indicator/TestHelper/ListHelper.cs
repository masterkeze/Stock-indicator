using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelper
{
    public class ListHelper
    {
        public static List<Double> GetDoubleListWithLength(int length)
        {
            if (length < 0) throw new ArgumentException("You passed in a negative length.", "length");
            List<Double> output = new List<Double>();
            for (int i = 0; i < length; i++)
            {
                output.Add(i);
            }
            return output;
        }
    }
}
