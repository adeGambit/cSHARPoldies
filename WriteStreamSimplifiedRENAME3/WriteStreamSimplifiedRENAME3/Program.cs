using System;
using System.IO;
namespace WriteStreamSimplifiedRENAME3
//using System;
//using System.IO;

//namespace Write_Stream//WriteStreamB1Ch7P171
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WriteStream";

            string path = "C:\\Users\\lower\\OneDrive\\Desktop\\robert.txt";//string path variable initialized
            string[] poem = new string[]//string array named/initialized
                {
                 "\tThis truth finds honest Tam o'Shanter",//ar
                "\n\tAs he from Ayr one night did canter",//ray
                "\n\tOld Ayr, which never a town surpasse",//con
                "\n\tFor honest men and bonnie lasses."//thents
                };
            string attrib = "\r\n\tTam O'Shanter (Robert Burns 1790)";//"attrib"-ed to be added after/attributed as/when

            try
            {
                //statments to be inserted (steps 5&6)
                using (StreamWriter writer = new StreamWriter(path))//5
                {//statements inserted that attempt to write the contents of the variable array into text file
                    foreach (string line in poem)
                    { writer.WriteLine(line); }

                }
                using (StreamWriter writer = new StreamWriter(path, true))//6
                {//inserted statments that attempt to append the contents of the regular variable into text file
                    writer.WriteLine(attrib);
                    writer.WriteLine("File Written: " + path); 
                }
                
            }
            catch (Exception error)
            { Console.WriteLine(error.Message); }//statments  displaying message when file cannot be successfully written
            Console.ReadKey();//run screen to reguard instead of instantly closing after running
        }
    }
}
