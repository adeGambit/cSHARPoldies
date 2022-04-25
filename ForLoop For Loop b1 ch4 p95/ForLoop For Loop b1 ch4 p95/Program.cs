using System;

namespace ForLoop//For_Loop_b1_ch4_p95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ForLoop";
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Loop Iteration: " + i);
                //Nested Loop to be inserted here ( step 4)
                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine("\tInner Loop Iteration: " + j);
                }
            }
            Console.ReadKey();
            
        }
    }
}
