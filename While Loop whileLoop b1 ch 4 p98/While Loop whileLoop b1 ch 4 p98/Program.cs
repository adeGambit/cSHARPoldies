using System;

namespace While_Loop//whileLoop_b1_ch_4_p98
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int i = 0;
            Console.Title = "While Loop";
            while (1<nums.Length)
            {
                nums[1] = 1;
                Console.Write("|" + nums[i]);
                i++;
            }
            Console.Write("\n\n");
            do
            {
                i--;
                //Statements to be inserted here (Step6)
            } 
            while (i>0);
            Console.ReadKey();
        }
    }
}
