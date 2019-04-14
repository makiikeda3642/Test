using System;

namespace P_D105
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input S");
            string input_line_1 = Console.ReadLine();
            string input_line_2 = Console.ReadLine();

            string result = "No";
            if(input_line_1.Length == input_line_2.Length)
            {
                result = "Yes";
            }
            Console.WriteLine(result);
        }
    }
}
