using System;

namespace P_D093
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input N M");
            string input_line_1 = Console.ReadLine();
            int N;
            if(!int.TryParse(input_line_1 , out N)) return;
            if(N < 1000 || N > 50000) return;

            string result = input_line_1;

            if(input_line_1.Replace(input_line_1[0].ToString(),"") != "")
            {
                result = "No";
            }

            Console.WriteLine(result.ToString());
        }
    }
}
