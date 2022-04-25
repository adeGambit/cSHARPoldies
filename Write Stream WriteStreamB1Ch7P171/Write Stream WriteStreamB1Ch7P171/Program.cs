using System;
using System.IO;

namespace Write_Stream//WriteStreamB1Ch7P171
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WriteStream";

            string path = "C:\\User\\lower\\OneDrive\\Desktop\\robert.txt";
            string poem = new string
                ("\tThis truth finds honest Tam o'Shanter\n\tAs he from Ayr one night did canter\n\tOld Ayr, which never a town surpasses\n\tFor honest men and bonnie lasses.");

            string attrib = "\r\n\tTam O'Shanter (Robert Burns 1790)";

            try
            {
                //statments to be inserted (steps 5&6)
                using (StreamWriter writer = new StreamWriter(path))//5
                {
                    foreach(string line in poem)
                    {writer.WriteLine( line );}
                    using (StreamWriter writer = new StreamWriter(path, true))//6
                    {
                        writer.WriteLine("File Written: " + path);
                    }
                }
            }

            catch(Exception error)
            {Console.WriteLine(error.Message);}
            Console.ReadKey();
        }
    }
}
