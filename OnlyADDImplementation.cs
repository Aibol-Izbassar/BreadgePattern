using System;
using System.Collections.Generic;
using System.Text;

namespace BreadgePattern
{
    class OnlyADDImplementation : ICalculatorImplementation
    {
        public int Add(int left, int right)
        {
            return left + right;
        }

        public int Divide(int left, int by)
        {
            if (by != 0)
            {
                int aa = 0;
                int bb = 0;

                if (left < 0)
                {
                    aa = ~left + 1;
                }
                else
                {
                    aa = left;
                }

                if (by < 0)
                {
                    bb = ~by + 1;
                }
                else
                {
                    bb = by;
                }

                int prod = 0;
                int x = 0;
                while ((prod + bb) <= aa)
                {
                    prod = prod + bb;
                    x++;
                }
                if ((left < 0 && by < 0) || (left > 0 && by > 0))
                {
                    return x;
                }
                else
                {
                    return ~x + 1;
                }
            }
            else
            {
                throw new DivideByZeroException();
            }
        }

        public int Multiply(int left, int by)
        {
            int aa = 0;
            int bb = 0;

            if (left < 0)
            {
                aa = ~left + 1;
            }
            else
            {
                aa = left;
            }
            if (by < 0)
            {
                bb = ~by + 1;
            }
            else
            {
                bb = by;
            }

            int result = 0;
            while (bb != 0)
            {
                if ((bb & 0x1) == 0x1)
                    result += aa;
                bb >>= 1;
                aa <<= 1;
            }
            if (left < 0 || by < 0)
            {
                return ~result + 1;
            }
            else
                return result;
        }

        public int Substract(int left, int right)
        {
            return left + (~right + 1);
        }

    }
}
