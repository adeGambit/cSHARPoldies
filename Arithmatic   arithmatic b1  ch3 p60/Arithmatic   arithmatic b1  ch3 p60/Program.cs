using System;

namespace Arithmatic//arithmatic_b1__ch3_p60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arithmatic";
            int a = 8;
            int b = 4;
            Console.WriteLine("Addition:\t" + (a + b));
            Console.WriteLine("Subtract:\t" + ( a - b));
            Console.WriteLine("Multiplication:\t" + (a * b));
            Console.WriteLine("Divisiont:\t" + (a/b));
            Console.WriteLine("Modulous:\t" + (a%b));
            Console.WriteLine("\nPostFix:\t" + (a++));
            Console.WriteLine("\nPostFIx.....:\t" + a);
            Console.WriteLine("\nPostFix:\t" + (b++));
            Console.WriteLine("\nPostFIx.....:\t" + b);
        }
    }
}
