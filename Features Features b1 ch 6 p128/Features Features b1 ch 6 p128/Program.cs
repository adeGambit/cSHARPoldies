using System;

namespace Features_Features_b1_ch_6_p128
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Features";
            Console.Write("Please Enter Text: ");
            string text = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("\nERROR: No Text Found!");
            }
            else
            {
                //Statements to be inserted (for Steps4-7).
                Console.WriteLine("\nThanks. You Entered:\n'"+text+"'");
                Console.WriteLine("\nText Lenght: "+text.Length);
                string query = text.StartsWith("C#") ? "Does " : "Does Not ";
                Console.WriteLine("Text " + query + "Start with'C#'");
                query = text.EndsWith("steps") ? "Does " : "Does Not ";
                Console.WriteLine("Text 5"+query+"Contain 'easy'");
            }
            Console.ReadKey();

        }
    }
}
