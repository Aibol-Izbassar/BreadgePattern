using System;
using System.Collections.Generic;
using System.Text;

namespace BreadgePattern
{
    class ChineesImplementation : ICalculatorImplementation
    {
        public int Add(int left, int right)
        {
            return left + right;
        }

        public int Divide(int left, int by)
        {
            int counter = 1;
            while (left>by)
            {
                left -= by;
                counter++;
            }
            return counter;
        }

        public int Multiply(int left, int by)
        {
            for (int i = 1; i < by; i++)
            {
                left += left;
            }
            return left;
        }

        public int Substract(int left, int right)
        {
            return left - right;
        }
    }
}
