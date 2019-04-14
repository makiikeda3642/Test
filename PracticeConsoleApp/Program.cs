using System;

namespace P_D097
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input");
            string input_line_1 = Console.ReadLine();

            int counter = 0;

            for(int i=0; i<7; i++)
            {
                int N;
                if(!int.TryParse(input_line_1.Split(' ')[i] , out N)) return;
                
                counter+=N;
            }
            
            string result = "no";

            if(counter >= 5)
            {
                result = "yes";
            }

            Console.WriteLine(result);
        }
    }
}
