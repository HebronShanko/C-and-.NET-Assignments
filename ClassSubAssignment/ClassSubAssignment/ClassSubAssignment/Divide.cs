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
        public void Division(int x, out int y)
        {
            int temp = 5;
            x = temp;
            int temp2 = 10;
            y = temp2;
            Console.WriteLine(y);

        }
         public void outMethod(out int Z)
        {
            Z = 100;
            Console.WriteLine(Z);
        }

    }
}
