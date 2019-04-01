using System;

namespace P_D117
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("please N");
            string input_N = Console.ReadLine();
            //Console.WriteLine("please S");
            string input_Data = Console.ReadLine();

            int N;
            if(!int.TryParse(input_N, out N)) return;
            if(N < 0 || N > 100) return;
            
            int result = 0;

            var list = input_Data.Split(' ');
            foreach(var item in list)
            {
                int num;
                if(!int.TryParse(item,out num)) return;

                result += num;
            }

            if(N == 0) result = 0;

            Console.WriteLine(result.ToString());
        }
    }
}
