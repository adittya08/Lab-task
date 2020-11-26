using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7
{
    class ICalculator : class1
    {
        int result;
        public int division(int x, int y)
        {
            return x / y;
        }

        public int multi(int x, int y)
        {
            return x * y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int sum(int x, int y)
        {
            return x + y;
        }
    }

    class class1 : ScientificCalculator
    {
        public class1()
        {
        }

        public int factorial(int x)
    {
        int i = 1;
        for (int s = 1; s <= x; s++)
        {
            i = i * s;
        }
        return i;
    }
        
    }
}
