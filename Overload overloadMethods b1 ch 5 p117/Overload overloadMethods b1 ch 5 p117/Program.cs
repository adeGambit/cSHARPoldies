using System;

namespace Overload//overloadMethods_b1_ch_5_p117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Overload";
            double num;
            double area;
            
            Console.Write("Please Enter Dimension In Feet: ");
            num = Convert.ToDouble(Console.ReadLine());
            area = computeArea(num);
            Console.WriteLine("\nCircle:\t\tArea = "+area+" sq.ft.");
            area = computeArea(num, num);
            Console.WriteLine("Square:\t\tarea = "+area+" sq.ft.");
            area = computeArea(num, num, 'T');
            Console.WriteLine("Triangle:\tArea = "+area+" sq.ft.");
            Console.ReadKey();
        }
        static double computeArea(double width)
        {
            double radius = width / 2;
            return ((radius * radius) * 3.141593);
           
        }
        static double computeArea(double width, double hight)
        {
            
            return (width * hight);
          
        }
        static double computeArea(double width, double hight, char letter)
        {// char never used, merely included per instruction "to determine which method should be called."
          
            return ((width / 2) * hight);
        }
    }
}
