using System;

namespace dateFormat//DateFormat_b1_ch_6_p153
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DateFormat";
            DateTime now = DateTime.Now;

            Console.WriteLine("Current Date and Time: " + now);
            Console.WriteLine("\nDay Name: "+now.DayOfWeek);
            Console.WriteLine("\nDate Only: " + now.ToShortDateString());
            Console.Write("\nTime Only: "+now.ToShortTimeString());

            now = now.AddYears(4);

            Console.Write("\n\nFuture Date: " + now);

            DateTime dt = new DateTime(2017, 7, 4, 8, 15, 30);

            Console.Write("\n\nSet Date and Time: {0:f}", dt);

            Console.Write("\nDay Name: {0:dddd}", dt);
            Console.Write("\nLong Date: {0:D}", dt);
            Console.Write("\nLong Time: {0:T}", dt);
            Console.ReadKey();
        }
    }
}
