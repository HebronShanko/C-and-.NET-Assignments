using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathOperation
    {
        public int Subtraction(int x)
        {
            return x - 4;
        }
        public int Subtraction(decimal p)
        {
            int result = Convert.ToInt32(p);
            return result - 12;
        }
        
        public int Subtraction(string z)
        {
            int A = Convert.ToInt32(z);
            return A - 5;
        }
    }
}
