using System;

namespace Parameter_ParameterPASSINGargument_b1_ch_5_p114
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parameter";
            double weight;
            string num;
            num = getWeight(out weight);
            Console.WriteLine(num + " lb = " + lbToKg(weight) + "kg");
            kgToLb(ref weight);
            Console.WriteLine(num + " kg = " + weight + "lb");
            Console.ReadKey();
        }
        static string getWeight(out double theWeight)
        {
            theWeight = 10;
            return "Ten";
        }
        static double lbToKg(double pounds = 5)
        {
            return (pounds * 0.45359237);
        }
        static void kgToLb(ref double weight)
        {
            weight = (weight / 0.45459237);
        }

    }
}
