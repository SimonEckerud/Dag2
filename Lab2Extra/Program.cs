using System;

namespace Lab2Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Convert.ToSingle(a);
            int b = 2;
            Convert.ToSingle(b);
            float c = a / b;
            Console.WriteLine(c);

            int d = 8 % 3;
            Console.WriteLine(d);
        }
    }
}
