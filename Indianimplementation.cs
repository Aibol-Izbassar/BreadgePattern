using System;
using System.Collections.Generic;
using System.Text;

namespace BreadgePattern
{
    class Indianimplementation : ICalculatorImplementation
    {
        public int Add(int left, int right)
        {
            return left + right;
        }

        public int Divide(int left, int by)
        {
            return left / by;
        }

        public int Multiply(int left, int by)
        {
            return left * by;
        }

        public int Substract(int left, int right)
        {
            return left - right;
        }
    }
}
