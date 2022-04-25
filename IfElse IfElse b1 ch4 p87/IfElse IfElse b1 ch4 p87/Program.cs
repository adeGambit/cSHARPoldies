using System;

namespace IfElse_IfElse_b1_ch4_p87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "If Else";
            Console.Write("Please Enter A Number:");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Thanks. Now Enter A Letter:");
            char letter = Convert.ToChar(Console.ReadLine());
            if (num>=6)
            {
                Console.WriteLine("\nNumber Exceeds 5");
                //nested statement to be inserted here (Step 5).

            }
            else
            {
                Console.WriteLine("\nNumber Is 5 Or Less");
            }
            Console.ReadKey();
            if (letter == 'C')
            {
                Console.WriteLine("Letter Is 'C'");

            }
        }
    }
}
