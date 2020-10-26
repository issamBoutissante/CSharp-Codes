using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(1,1);
            calculator.ShowAddition();
            calculator.ShowMultiplication();

            Console.ReadKey();
        }
    }
    static class Extensions
    {
        internal static void ShowMultiplication(this Calculator cal)
        {
            Console.WriteLine("the result of multiplication is : " + (cal.Number_1 + cal.Number_2));
        }
    }
}
