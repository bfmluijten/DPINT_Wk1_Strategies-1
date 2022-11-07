using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies.Converters
{
    internal class BinaryNumberConverter : INumberConverter
    {
        public string ToLocalString(int number)
        {
            return Convert.ToString(number, 2);
        }

        public int ToNumerical(string number)
        {
            return Convert.ToInt32(number, 2);
        }
    }
}
