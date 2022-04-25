using System;

namespace Precedence//Precedence_b1_ch3_p80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Precidence";
            int sum;
            sum = 1 + 4 * 3;
            Console.Write("Default Order:\t\t" + sum);
            sum = (1 + 4) * 3;
            Console.Write("\nForced Order:\t\t" + sum + "\n");
            sum = 7 - 4 + 2;
            Console.Write("\nDefault Directions:\t" + sum);
            sum = 7 - (4 + 2);
            Console.Write("\nForced Direction:\t" + sum);
            Console.ReadKey();
            //2new line additions to match example format
        }
    }
}
