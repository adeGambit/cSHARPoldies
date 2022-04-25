using System;
using System.IO;

namespace WriteText//WriteText_b1_ch7_p159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WriteText";

            //editing line below to include your user name
            string path = "C:\\Users\\lower\\OneDrive\\Desktop\\poem.txt";
            string poem = "\r\n\t\tI never saw a man who looked";
            poem += "\r\n\tWith such a wisful eye";
            poem += "\r\n\tUpon that little tent of blue";
            poem += "\r\n\tWhich prisoners call the sky";

            if (File.Exists(path))
            {
                Console.WriteLine("File Already Exists" + path);
            }
            else
            {
                //step 5 statments to be inserted
                try
                {
                    File.WriteAllText(path, poem);
                    Console.WriteLine("File Written" + path);

                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                }
                Console.ReadKey();
            }
        }
    }
