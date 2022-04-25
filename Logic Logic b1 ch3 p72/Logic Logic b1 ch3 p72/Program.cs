using System;

namespace Logic//Logic_b1_ch3_p72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Logic";
            bool yes = true, no = false;
            Console.Write("AND Logic:");
            Console.Write("\t(yes && yes):" + (yes && yes));
            Console.Write("\n\t\t(yes && no)" + (yes && no));
            Console.Write("\n\t\t(no && no):" + (no && no));
            Console.Write("\n\nOR Logic:");
            Console.Write("\t(yes||yes):" + (yes || yes));
            Console.Write("\n\t\t(yes||no):" + (yes || no));
            Console.Write("\n\t\t(no||no):" + (no || no));
            Console.Write("\n\nNOT Logic:");
            Console.Write("\t yes = " + yes);
            Console.Write("\t !yes = " + !yes);
            Console.Write("\n\t\t no =" + no);
            Console.Write("\t !no = " + !no);
            Console.ReadKey();
        }
    }
}
