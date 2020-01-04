using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public float pervii { get; set; }
        public float vtoroi { get; set; }

        public string op { get; set; }

        public float result { get; set; }

        public static float Operation(float x, string op, float y)
        {
            switch (op)
            {
                case "+":
                return x + y;
                break;
                case "-":
                return x - y;
                break;
                case "*":
                return x * y;
                break;
                case "/":
                return x / y;
                break;




            }
            return x+y;
          }
    }
}
