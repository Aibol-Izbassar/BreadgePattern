using System;
using System.Collections.Generic;
using System.Text;

namespace BreadgePattern
{
    class ScincetificCalculator:ICalculator, IScienceCalculator
    {
        public int Add(int left, int right)
        {
            return left + right;
        }

        public int Divide(int left, int by)
        {
            return left / by;
        }

        public double log2(double left)
        {
            return Math.Log2(left);
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
