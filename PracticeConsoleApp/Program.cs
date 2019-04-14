using System;

namespace P_D106
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input M");
            string input_line_1 = Console.ReadLine();

            int N;
            if(!int.TryParse(input_line_1 , out N)) return;
            if(N < 1 || N > 100) return;

            //Console.WriteLine("please input N");
            string input_line_2 = Console.ReadLine();
            int M;
            if(!int.TryParse(input_line_2 , out M)) return;
            if(M < 1 || M > 100) return;

            int result = N%M;

            Console.WriteLine(result.ToString());
        }
    }
}
