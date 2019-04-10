using System;

namespace P_D114
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please a b");
            string input_ab = Console.ReadLine();
            
            double a;
            if(!double.TryParse(input_ab.Split(' ')[0], out a)) return;
            if(a < 0D || a > 50D) return;
            
            double b;
            if(!double.TryParse(input_ab.Split(' ')[1], out b)) return;
            if(b < 1D || b > 10000D) return;
            double result = Math.Floor(b + b*a/100D);

            Console.WriteLine(Convert.ToInt32(result).ToString());
        }
    }
}
