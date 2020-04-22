using System;

namespace BreadgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator<ChineesImplementation> simple = new SimpleCalculator<ChineesImplementation>();
            Console.WriteLine(simple.Multiply(10, 2));





            //Add
            Console.WriteLine(Add(-10, 10));

            //Minus
            Console.WriteLine(Minus(10, 10));

            //Multiple
            Console.WriteLine(Multiple(20, -1));
           
            //divide
            Console.WriteLine(divide(100, -2));

        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiple(int a, int b)
        {
            int aa = 0;
            int bb = 0;

            if (a < 0)
            {
                aa = ~a + 1;
            }
            else
            {
                aa = a;
            }
            if (b < 0)
            {
                bb = ~b + 1;
            }
            else
            {
                bb = b;
            }

            int result = 0;
            while (bb != 0)
            {
                if ((bb & 0x1) == 0x1)
                    result += aa;
                bb >>= 1;
                aa <<= 1;
            }
            if (a<0 || b<0)
            {
                return ~result + 1;
            }
            else
                return result;

        }


        public static int Minus(int a, int b)
        {
            int s = a + (~b + 1);
            return s;
        }

        public static int divide(int a, int b)
        {
            if (b != 0)
            {
                int aa = 0;
                int bb = 0;

                if (a < 0)
                {
                    aa = ~a + 1;
                }
                else
                {
                    aa = a;
                }

                if (b < 0)
                {
                    bb = ~b + 1;
                }
                else
                {
                    bb = b;
                }

                int prod = 0;
                int x = 0;
                while ((prod + bb) <= aa)
                {
                    prod = prod + bb;
                    x++;
                }
                if ((a < 0 && b < 0) || (a > 0 && b > 0))
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
    }
}
