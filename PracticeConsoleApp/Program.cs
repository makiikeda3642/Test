using System;

namespace PracticeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please M");
            string input = Console.ReadLine();
            int M;
            if(!int.TryParse(input.Split(' ')[0], out M)) return;
            //int N;
            //if(!int.TryParse(input.Split(' ')[1], out N)) return;
            Console.WriteLine("Output is");
            Console.WriteLine(M.ToString());
        }
    }
}
