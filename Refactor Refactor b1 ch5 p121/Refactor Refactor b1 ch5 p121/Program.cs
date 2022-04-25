using System;

namespace Refactor_Refactor_b1_ch5_p121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Refactor";
            computeFactorials(1, 8);
            Console.ReadKey();
        }
        static int factorial(int num)
        {
            int result;
            if(num == 1)
            {
                result = 1;
            }
            else
            {
                result = (factorial(num - 1) * num);
            }
            return result;
        }
        static void computeFactorials(int num, int max)
        {
            while (num <= max)
            {
                Console.Write("Factorial Of " + num + " : ");
                Console.WriteLine(factorial(num));
                num++;
            }
        }

    }
}
