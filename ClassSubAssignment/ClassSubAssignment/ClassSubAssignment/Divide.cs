using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubAssignment
{
    class Divide
    {
        public void Division(int x)
        {
            x = x / 2;
            Console.WriteLine(x);
        }
        public void Division(out int x)
        {
            int temp = 5;
            x = temp;
        }
    }
}
