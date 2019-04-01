using System;

namespace P_D116
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("please N");
            string input_N = Console.ReadLine();

            int N;
            if(!int.TryParse(input_N, out N)) return;
            if(N < 100 || N > 100000) return;
            
            int result = N - N%100;

            Console.WriteLine(result.ToString());
        }
    }
}
