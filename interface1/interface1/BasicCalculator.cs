using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    class BasicCalculator : BasicCalculatorInt
    {
        public int Division(int x, int y)
        {
            int c = x / y;
            return c;

        }

        public int Multiplication(int x, int y)
        {
            int c = x * y;
            return c;
        }

        public int Sub(int x, int y)
        {
            int c = x - y;
            return c;
        }

        public int Sum(int x, int y)
        {
            int c = x + y;
            return c;
        }
    }
}
