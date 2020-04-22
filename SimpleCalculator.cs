using System;
using System.Collections.Generic;
using System.Text;

namespace BreadgePattern
{
    class SimpleCalculator<T> : ICalculator where T: ICalculatorImplementation, new()
    {
        T implementation;
        public SimpleCalculator()
        {
            implementation = new T();
        }
        public int Add(int left, int right)
        {
            return implementation.Add(left, right);
        }

        public int Divide(int left, int by)
        {
            return implementation.Divide(left, by);
        }

        public int Multiply(int left, int by)
        {
            return implementation.Multiply(left, by);
        }

        public int Substract(int left, int right)
        {
            return implementation.Substract(left, right);
        }
    }
}
