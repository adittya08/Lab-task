using System;

namespace Lab_7
{
    class Program
    {


        static void Main(string[] args)
        {
            ICalculator c = new ICalculator();
            Console.WriteLine(" Sum = " + c.sum(10, 5));
            Console.WriteLine(" Sub = " + c.sub(10, 5));
            Console.WriteLine(" Multiplication = " + c.multi(10, 5));
            Console.WriteLine(" Division = " + c.division(10, 5));
            Console.WriteLine(" Factorial = " + c.factorial(5));
        }
    }
}

