using System;

namespace Switching_Branches_b1_ch_4_p90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Switch";
            int num = 3;
            string day;
            switch (num)
            {
                case 1: day = "Monday";break;
                case 2: day = "Tuesday";break;
                case 3: day = "Wednesday";break;
                case 4: day = "Thursday";break;
                case 5: day = "Friday";break;
                //Default statement to be inserted here (Step5)
                default: day = "weekend Day";break;
            }
            Console.WriteLine("Day" + num + ":" + day);
            Console.ReadKey();
        }
    }
}
