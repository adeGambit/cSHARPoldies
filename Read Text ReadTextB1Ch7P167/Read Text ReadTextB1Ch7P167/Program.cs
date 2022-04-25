using System;
using System.IO;//further class library available to the program
namespace Read_Text_ReadTextB1Ch7P167//namespace open
{
    class Program
    {//class open
        static void Main(string[] args)
        {//main open
            Console.Title="Read Text";//prints "read text" to title bar

            string path = "C:\\Users\\lower\\OneDrive\\Desktop\\word.txt";//file path+ variable initialized

            if (File.Exists( path ))//statement tests if a file already exists as specified
            {//if open
                //statments to be entered here (step5).
                try
                {//try open
                    //steps 6&7 to be entered her
                    string text = File.ReadAllText( path );//6: statments inserted to assign the text file contents to a variable and display its value
                    Console.WriteLine("File Read: " + path + "\n");
                    Console.WriteLine(text + "\n");

                    string[]lines = File.ReadAllLines( path );//7:statements inserted to assign the text file contents to an array variable and display each element with a counter
                    int num = 1;
                    foreach (string line in lines)
                    {
                        Console.WriteLine(num + " : " + line);
                        num++;
                    }
                }
                catch( Exception error)//statemtn to display "file cannot be read" message
                {
                    Console.WriteLine(error.Message);//error message catch
                }
            }
            else
            {
                Console.WriteLine("File Not Found: " + path);
            }//the message printed to console plus the potentially faulty path for troubleshooting
            Console.ReadKey();
        }
    }
}
