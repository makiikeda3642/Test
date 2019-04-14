using System;

namespace P_D108
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input t");
            string input_line = Console.ReadLine();
            
            int t;
            if(!int.TryParse(input_line.Split(' ')[0] , out t)) return;
            if(t < 1 || t > 24) return;

            int result = 0;
            while(result * t < 24)
            {
                result++;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
