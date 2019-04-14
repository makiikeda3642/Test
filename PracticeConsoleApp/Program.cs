using System;

namespace P_D101
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input N M");
            string input_line_1 = Console.ReadLine();

            int N;
            if(!int.TryParse(input_line_1.Split(' ')[0] , out N)) return;
            if(N < 1 || N > 50) return;

            int M;
            if(!int.TryParse(input_line_1.Split(' ')[1] , out M)) return;
            if(M < 1 || M > 50) return;


            string result = "NO";

            if(N%2==0 && M%2==1)
            {
                result = "YES";
            }
            else if(N%2==1 && M%2==0)
            {
                result = "YES";
            }

            Console.WriteLine(result);
        }
    }
}
