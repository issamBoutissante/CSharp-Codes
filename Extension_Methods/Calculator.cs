using System;

namespace Extension_Methods
{
    internal class Calculator
    {
        internal int Number_1 { get; set; }
        internal int Number_2 { get ; set ; }
          public Calculator(int number_1, int number_2)
          {
            Number_1 = number_1;
            Number_2 = number_2;
          }
 
        public void ShowAddition()
        {
            Console.WriteLine("the result of addition is " +( Number_1 + Number_2).ToString());
        }
  
    }
}