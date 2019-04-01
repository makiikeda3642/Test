using System;

namespace P_D118
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please S");
            string input_S = Console.ReadLine();
            //Console.WriteLine("please N");
            string input_N = Console.ReadLine();

            int N;
            if(!int.TryParse(input_N, out N)) return;


            int result = 0;
            if(input_S == "S")
            {
                if(N < 1 || N > 65) return;

                result = 1926 + N -1;
            }
            else if(input_S == "H")
            {
                if(N < 1 || N > 31) return;

                result = 1989 + N -1;
            }
            else
            {
                return;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
