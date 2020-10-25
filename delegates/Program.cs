using System;
using System.ComponentModel;

namespace delegates
{
    class Program
    {
        delegate int operation(int a, int b);
        static void Main(string[] args)
        {

            int result =multiply()(2, 4);
            Console.WriteLine(result);


        }

        static operation multiply()
        {
            return (int a, int b) =>
            {
                return a * b;
            };
        }


        static void calculate(operation op)
        {
            Console.WriteLine(op(2,3));
        }
        static int addition(int a,int b)
        {
            return a + b;
        }


    }
}
