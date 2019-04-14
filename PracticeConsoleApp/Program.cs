using System;

namespace P_D095
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input N M");
            string input_line_1 = Console.ReadLine();
            int N;
            if(!int.TryParse(input_line_1 , out N)) return;
            if(N < 100 || N > 2000) return;

            string input_line_2 = Console.ReadLine();
            int M;
            if(!int.TryParse(input_line_2 , out M)) return;
            if(M < 100 || M > 2000) return;


            int result = N/M;

            Console.WriteLine(result.ToString());
        }
    }
}
