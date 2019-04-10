using System;

namespace P_D115
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("please N");
            string input_N = Console.ReadLine();

            int N;
            if(!int.TryParse(input_N, out N)) return;
            if(N < 2 || N > 50) return;
            
            int result = N%2==0 ? N/2 : (N-1)/2;

            Console.WriteLine(result.ToString());
        }
    }
}
