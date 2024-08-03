using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm_b1
{
    public class Tong
    {
        public int tong(int a, int b)
        {
            return a + b; 
        }
        public bool KiemTraSoNguyen(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
