using System;

namespace Constant//Constant_b1_ch2_p53
{
    class Program
    {enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        static void Main(string[] args)
        {
            Console.Title = "Constant";
            const double pi = 3.14159265358979;
            var daysType = typeof( Days );
            Console.WriteLine("Pi Type: " + pi.GetType());
            Console.WriteLine("Circumference: " + (pi * 3));
            Console.WriteLine("\nFirst Name: " + Days.Sat);
            Console.WriteLine("1st Index: " + (int) Days.Sat);
            string name = Enum.GetName(daysType, 1);
            Console.WriteLine("\n2ndIndex: " + name );
            bool flag = Enum.IsDefined(daysType, "Mon");
            Console.WriteLine("Contains Mon? "+ flag);
            Console.ReadKey();
        }
    }
}
