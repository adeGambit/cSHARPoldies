using System;

namespace format//Format_b1__ch6_p149
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title ="Format";//window title named

            double sum = 2500.00;//currency string initialized and value defined
            Console.WriteLine("Currency String: " + sum.ToString("C"));
            //
            Console.Write(String.Format("\nGeneral:\t {0:G}", sum));
            Console.Write(String.Format("\nFixed Point:\t {0:F}", sum));
            Console.Write(String.Format("\nNumber:\t\t {0:N}", sum));
            Console.Write(String.Format("\nCurrency:\t {0:C}", sum));
            //
            sum/=1000.00;//reducing numeric value
            Console.Write(String.Format("\nPercentage:\t {0:P} ", sum));
            Console.Write(String.Format("\nZero Padded:\t {0:00.0000}\n", sum));
            //output in percentage string format with padded zeroes
            //
            String data = "Mike,McGrath,Author";//string array declaration and contents
            string [] items = data.Split(',');//string array output splitters
            //
            foreach(string item in items)
            {
                Console.Write(String.Format("\n * {0}" ,item));
                

            }

        }
    }
}
