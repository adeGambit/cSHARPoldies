using System;

namespace Copied//CopiedANDswappingStrings_b1_ch6_p136
{
    class Program
    {
        static void Main(string[] args){             
            Console.Title = "Copied";

            string car1 = "Ghibli";
            string car2 = "GranTurismo";

            Console.WriteLine("Original");
            Console.WriteLine("\tCar 1: " + car1 +"\t\tCar 2:" + car2);

            car1 = String.Copy(car2);

            Console.WriteLine("\nCopied:");
            Console.WriteLine("\tCar 1 :" + car1 + "\tCar 2: " + car2);

            //review
            int num = car1.Length;
            char[] model = new char[num];
            car1.CopyTo(0, model, 0, num);

            Console.WriteLine("\nCharacter Array: ");
            foreach (char c in model) {
                Console.Write(c + " ");
            }

            //review
            car1 = car1.Remove(4);
            Console.WriteLine("\n\nRemoved... \tCar 1: " + car1);
            car1 = car1.Insert(0, "Maserati ");
            car1 = car1.Insert(13, "Cabrio");//MasCabrio(ACTUALLY MasCabrioerati for index 4 instead of 13//experiment//special thanks to AS5

            //review
            Console.WriteLine("\n\nInserted... \tCar 1: " + car1);
            car1 = car1.Replace("GranCabrio", "Quattroporte");
            
            Console.WriteLine("\nReplaced...\tCar 1: " + car1);
            Console.ReadKey();

            

            
        }
    }
}
