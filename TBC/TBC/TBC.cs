using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBC
{
    public class TBC
    {
        public double Tinh(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("dãy số ko đc để trống");
            }
            return numbers.Average();
        }
    }
}
