using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hieu
{
    public class TinhHieu
    {
        public int hieu(int a, int b)
        {
            return a - b;
        }

        public bool check(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
