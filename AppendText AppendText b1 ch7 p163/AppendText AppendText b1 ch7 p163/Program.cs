using System;
using System.IO;
namespace AppendText//AppendText_b1_ch7_p163
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="AppendText";

            string path = "C:\\Users\\lower\\OneDrive\\Desktop\\oscar.txt";
            string[] poem = new string[]
            {
                "\t\n Debtors' Yard the stones are hard",
                "\tAnd the dripping wall is high"
            };
            string attrib = "\r\n\tThe Ballad of Reading Gaol";
            attrib += "(Oscar Wilde 1898)";
            if(File.Exists(path))
            {
                //Statements to be inserted here ( step 5 ).
                File.AppendAllText(path, attrib);
                Console.WriteLine("Appended to File: " + path);
            }
            else
            {
                //Statements to be inserted here (step6).
                try
                {
                    File.WriteAllLines(path, poem);
                    Console.WriteLine("File Written: " + path);
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            Console.ReadKey();

        }
    }
}
