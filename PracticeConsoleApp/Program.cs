using System;

namespace P_D112
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please n");
            string input_n = Console.ReadLine();
            
            int n;
            if(!int.TryParse(input_n , out n)) return;
            if(n < 1 || n > 200) return;
            
            //Console.WriteLine("please n");
            string input_h = Console.ReadLine();

            int h;
            if(!int.TryParse(input_h , out h)) return;
            if(h < 1 || h > 24) return;

            double result = n*h;

            Console.WriteLine(result.ToString());
        }
    }
}
