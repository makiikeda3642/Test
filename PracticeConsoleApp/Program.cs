using System;

namespace P_D111
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please n");
            string input_n = Console.ReadLine();
            
            int n;
            if(!int.TryParse(input_n , out n)) return;
            if(n < 1 || n > 100) return;
            
            //Console.WriteLine("please n");
            string input_S = Console.ReadLine();

            string result = "";
            if(input_S.Length >= n)
            {
                result = input_S.Substring(0,n);
            }
            else
            {
                result = input_S;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
