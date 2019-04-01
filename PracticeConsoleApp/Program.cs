using System;

namespace P_D119
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please N");
            string input = Console.ReadLine();
            //1<= N <= 15
            double N;
            if(!double.TryParse(input, out N)) return;
            
            if( N < 1 || N > 15 ) return;

            string temp = String.Format("3.141592653589793");
            string result = temp.Substring(0,(int)N + 2);
            Console.WriteLine(result);
        }
    }
}
