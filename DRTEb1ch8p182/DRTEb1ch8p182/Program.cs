using System;

namespace DRTEb1ch8p182//FCTEb1ch8p185//
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title="Detecting real-time errors"; 8/p182/p1

            //Console.Title = "fixing compile-time errors";8/p185/p2

             Console.Title = "Debugging Code";//8/p188/p3


            // int num = 1;//p1

            //bool flag = true;
            //IConvertible convertible = flag;
            //char letter = convertible.ToChar(null);

            //bool flag = true;
            //IConvertible convertible = flag;
            //char letter = convertible.ToChar(null);

            //int[] nums = new int[10];//p2
            //for (int i = 1; i < 20; i++) { nums[i]=i}


            int pass = 0;
            int unit =1;

            for (int i = 1; i < 3; i++)
            {
                pass = (pass + 1);
                unit = square(unit);

            }

           


        }
        static int square(int num)
        {
            return (num * num);
        }
    }
}
