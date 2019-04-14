using System;

namespace P_D107
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input S");
            string input_line_1 = Console.ReadLine();
            
            string S = input_line_1;
            
            //Console.WriteLine("please input c");
            string input_line_2 = Console.ReadLine();

            string c = input_line_2;

            Console.WriteLine(c + S + c);
        }
    }
}
