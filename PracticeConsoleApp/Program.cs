using System;

namespace P_D104
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input N");
            string input_line_1 = Console.ReadLine();

            int N;
            if(!int.TryParse(input_line_1 , out N)) return;
            if(N < 1 || N > 50) return;

            int result = 1000;

            if(N >= 10)
            {
                result = N * 150;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
