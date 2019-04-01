using System;

namespace P_D120
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please N");
            string input = Console.ReadLine();
            //1<= N <= 50
            int N;
            if(!int.TryParse(input, out N)) return;
            
            int result = N*12;

            Console.WriteLine(result.ToString());
        }
    }
}
