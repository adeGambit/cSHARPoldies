using System;

namespace Method//Method_b1_ch_5_p109
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Method";
            bodyTempC();
            Console.WriteLine("Farenheit:\t" + bodyTempF() + "*F");
            Console.WriteLine("Kelvin:\t" + bodyTempK() + "K");
           Console.ReadKey();
            
        }
        static void bodyTempC()
        {
            Console.WriteLine("Body Temperature...");
            Console.WriteLine("Centigrade:\t37*C");
        }
        static double bodyTempF()
        {
            double temperature = 98.6;
            return temperature;
        }
        static int bodyTempK()
        {
            int temperature = 310;
            return temperature;
        }
    }
}
