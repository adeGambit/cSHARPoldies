using System;

namespace Assign //assign b1 ch3 p64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assign";
            int a;
            int b;
            Console.Write("Assign Values:");
            Console.Write("\t a =" + (a = 8));
            Console.WriteLine("\t b =" + (b = 4));
            Console.Write("\n\n Add and Assign:");
            Console.Write("\t a += b (8 += 4)\t a = " + (a += b));
            Console.Write("\n\n Subtract and Assign:");
            Console.Write("\t a + -= b (12 -= 4)\t a = " + (a -= b));
            Console.Write("\n\n Multiply and Assign:");
            Console.Write("\t a = *= b (8 *= 4)\t a =" + (a *= b));
            Console.Write("\n\n Divide and Assign:");
            Console.Write("\t a + /= b (32 /= 4)\t a =" + (a /= b));
            Console.Write("\n\n Modulous and Assign:");
            Console.Write("\t a + %= b (8 %= 4)\t a =" + (a %= b));
            Console.ReadKey();
        }
    }
}
