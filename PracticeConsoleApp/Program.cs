using System;

namespace P_D102
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input N");
            string input_line_1 = Console.ReadLine();

            int N;
            if(!int.TryParse(input_line_1 , out N)) return;
            if(N < 1 || N > 30) return;

            int result = 100;

            result+=(N*10);

            Console.WriteLine(result.ToString());
        }
    }
}
