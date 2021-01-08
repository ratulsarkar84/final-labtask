using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("*************************");

            BasicCalculator bc = new BasicCalculator();
            Console.WriteLine("Sum : " + bc.Sum(12, 13));
            Console.WriteLine("Sub : " + bc.Sub(12, 13));
            Console.WriteLine("Multiplication : " + bc.Multiplication(2, 3));
            Console.WriteLine("Division : " + bc.Division(12, 6));
            ScientificCalculator sc = new ScientificCalculator();
            Console.WriteLine("*************************");
            Console.WriteLine("Scientific Calculator");
            Console.WriteLine("*************************");
            Console.WriteLine("Logarithm : " + sc.Logarithm(1));
            Console.WriteLine("Root : " + sc.Root(64));
            Console.WriteLine("Power : " + sc.XtoY(3, 3));
        }
    }
}
