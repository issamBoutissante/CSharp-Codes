using System;

namespace Genirics
{
    class Program
    {
        static void Main(string[] args)
        {
            showTypeOf <string> showTypeOf = new showTypeOf<string>();
            Type type = showTypeOf.getType();
            Console.WriteLine(type);
        }
    }
    internal class showTypeOf<T> where T : class
    {
        public Type getType()
        {
            return typeof(T);
        }
    }

    internal class constraintClass
    {
        public T add<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
