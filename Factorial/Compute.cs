using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Compute
    {
        //uses the recursive call to compute factorial
        public static int Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return n * Factorial(n-1);
        }

        //recursive call of itself
        public static int Fib(int n)
        {
            if((n == 0) || (n == 1))
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
