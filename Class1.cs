using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class NumberManipulater
    {
        public int FindMin(int a, int b, int z, int x)
        {
            int c;
            c = ((b + z) * (a - b)) / x;
            return c;
        }

    }

}
