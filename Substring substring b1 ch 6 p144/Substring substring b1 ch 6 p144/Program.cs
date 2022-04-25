using System;

namespace Substring//substring_b1_ch_6_p144
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Substring";//window's title declared and projected

            string text = "My dog is a cute dog";//string variable initialized
            Console.WriteLine(text + "\tLength: " + text.Length);

            Console.WriteLine("\nPleaese Enter A Substring To Seek: ");//requesting user input
            string sub = Console.ReadLine();//input taken and initialized

            char[] arr = new char[sub.Length];//char array
            sub.CopyTo(0, arr, 0, sub.Length);//copied value into array

            int pos = text.IndexOf(sub);//seeking 1st occuranceof the substring
            report(pos, sub);//calling the method/function defined to report

            pos = text.LastIndexOf(sub);//seeking last occurrence of substring
            report(pos, sub);//reporting live, it's April O'Neil

            pos = text.IndexOfAny(arr);//seeking 1st occurrence of any character of the sbstring
            report(pos, text.Substring(pos, 1));//reporting result

            pos = text.LastIndexOfAny(arr);//seeking last occurrence of any charactter of the substring
            report(pos, text.Substring(pos, 1));//reporting result
            Console.ReadKey();//full stop ( without closing immediatly)
        }
        static void report( int pos, string sub)
        {//added method/funciton declaration to report result of substring search
            if (pos != -1)// found if / if found //report this
            {
                Console.WriteLine("'" + sub + "'Found At " + pos);
            }
            else// not found else / found not //report this
            {
                Console.WriteLine("'" + sub +"'Not Found!");
            }
        }
    }
}
