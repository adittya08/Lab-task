using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator mycalc;
            mycalc = new MyCalc();
            mycalc.Sum(5, 5);

            MyCalc mc = new MyCalc();
            mc.Sum(5, 5);
        }
    }

    public interface ICalculator
    {
        void Sum(int a, int b);
    }

    public class MyCalc : ICalculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
