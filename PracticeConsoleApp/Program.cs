using System;

namespace P_D103
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input S");
            string input_line_1 = Console.ReadLine();

            for(int i=input_line_1.Length - 1; i>=0; i--)
            {
                Console.Write(input_line_1[i]);
            }

            Console.WriteLine();
        }
    }
}
