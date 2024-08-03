using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tich
{
    public class tich
    {
        public int Tich(int a, int b)
        {
            return a * b;
        }
        public bool check(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
