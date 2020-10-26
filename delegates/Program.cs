using System;
using System.ComponentModel;

namespace delegates
{
    class Program
    {
        delegate int operation(int a, int b);
        delegate string voidFunction(string name);
        static void Main(string[] args)
        {

            int result =multiply()(2, 4);
            Console.WriteLine(result);

            string text =sayHi(name=>{
                return string.Format("hello "+name);
            })("issam");

            Console.WriteLine(text);


            //Action and func
            Action<string> sayhi = name => {
                Console.WriteLine("you are doing will "+name);
            };

            Func<Action<string>> getSomething = () =>
            {
                return sayhi;
            };
            getSomething()("issam");

        }
        static voidFunction sayHi(voidFunction voidFunction)
        {
            return voidFunction;
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
