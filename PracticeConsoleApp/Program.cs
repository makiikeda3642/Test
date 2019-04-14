using System;

namespace P_D110
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please abc");
            string input_abc = Console.ReadLine();
            
            int a;
            if(!int.TryParse(input_abc.Split(' ')[0] , out a)) return;
            if(a < 0 || a > 100) return;
            
            int b;
            if(!int.TryParse(input_abc.Split(' ')[1] , out b)) return;
            if(b < 0 || b > 100) return;

            int c;
            if(!int.TryParse(input_abc.Split(' ')[2] , out c)) return;
            if(c < 0 || c > 100) return;

            int result = a*b*c;

            Console.WriteLine(result.ToString());
        }
    }
}
