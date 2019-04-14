using System;

namespace P_D098
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input a b");
            string input_line_1 = Console.ReadLine();
            int a;
            if(!int.TryParse(input_line_1.Split(' ')[0] , out a)) return;
            if(a < 200000 || a > 1000000) return;

            int b;
            if(!int.TryParse(input_line_1.Split(' ')[1] , out b)) return;
            if(b < 1 || b > 6) return;


            int result = a*b;

            Console.WriteLine(result.ToString());
        }
    }
}
