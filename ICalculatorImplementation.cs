using System;
using System.Collections.Generic;
using System.Text;

namespace BreadgePattern
{
    interface ICalculatorImplementation
    {
        int Add(int left, int right);
        int Substract(int left, int right);
        int Multiply(int left, int by);
        int Divide(int left, int by);
    }
}
