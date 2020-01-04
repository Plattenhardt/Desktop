using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.pervii = Convert.ToInt32(Console.ReadLine());
            calculator.op = Convert.ToString(Console.ReadLine());
            calculator.vtoroi = Convert.ToInt32(Console.ReadLine());

            
            float res = Calculator.Operation(calculator.pervii, calculator.op, calculator.vtoroi);

            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}
