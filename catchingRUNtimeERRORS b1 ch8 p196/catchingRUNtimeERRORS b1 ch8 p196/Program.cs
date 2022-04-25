using System;

namespace catchingRUNtimeERRORS_b1_ch8_p196
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cathing Run-Time Errors";

            try
            {
                Console.WriteLine("Please Enter A Number: ");
                double num1 = Convert.ToInt16(Console.ReadLine());

                Console.Write("Now Enter Another Number: ");
                double num2 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Total: " + (num1 + num2));
            }
            catch (OverflowException)
            { Console.WriteLine("\nMaximum: "+ Int16.MaxValue); }
        }
    }
}