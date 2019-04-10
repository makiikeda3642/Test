using System;

namespace P_D113
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please h:m");
            string input_hm = Console.ReadLine();
            
            int h;
            if(!int.TryParse(input_hm.Split(':')[0], out h)) return;
            if(h < 0 || h > 12) return;
            
            int m;
            if(!int.TryParse(input_hm.Split(':')[1], out m)) return;
            if(m < 0 || m > 59) return;

            double result = h >= 8 ? h - 8 : h + 16;

            Console.WriteLine(result.ToString() + ":" + m.ToString());
        }
    }
}
