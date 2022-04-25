using System;
using System.IO;

namespace Read_Stream//read_stream_b1_ch7_p175
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="ReadStream";

            string path = "C:\\Users\\lower\\OneDrive\\Desktop\\TopFive.csv";

            try
            {
                //statments from step 5
                using (StreamReader reader=new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //statements from 6&7
                        if (line.IndexOf("Rank") != -1) line = line.ToUpper();
                        if (line.IndexOf("Sia") != -1) line += "ft.Sean Paul";

                        string[] sub = line.Split(',');
                        line = String.Format("{0,-30}{1,-20}", sub[1], sub[2]);
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadKey();
        }
    }
}
