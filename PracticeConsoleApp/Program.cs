using System;
using System.Collections.Generic;

namespace P_D091
{
    class Program
    {
        const int P_I_MAX = 10;
        const int P_I_MIN = 1;
        const int P_NUM_MAX = 5;
        const int P_NUM_MIN = 1;
        const int ALLOW_OUT_LEVEL = 2;
        
        static void Main(string[] args)
        {
            int result = 0;

            //Console.WriteLine("please input");

            var input_data_lsit = Console.ReadLine().Split(' ');
            var p_i = input_data_lsit.Length;

            if(!(p_i <= P_I_MAX && p_i >= P_I_MIN)) return;

            List<int> p_list = new List<int>();
            for(int i=0;i<p_i;i++)
            {
                int p;
                
                if(!int.TryParse(input_data_lsit[i] , out p)) return;
                if(!(p>=P_NUM_MIN && p <= P_NUM_MAX))  return;

                p_list.Add(p);
            }

            foreach(var p in p_list)
            {
                if(p <= ALLOW_OUT_LEVEL)result++;
            }

            Console.WriteLine(result);
        }
    }
}