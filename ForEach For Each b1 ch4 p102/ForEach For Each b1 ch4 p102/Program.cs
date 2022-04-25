using System;

namespace ForEach//For_Each_b1_ch4_p102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ForEach";
            string[] websites = new string[5] { "Google", "YouTube", "Facebook", "Baidu", "Yahoo!" };
            Console.WriteLine("Popular Websites...");
            int rank = 1;
            foreach (string site in websites)
            {
                Console.WriteLine("Position:" + rank + "\t" + site);
                rank++;

            }
            Console.ReadKey();
        }
    }
}
