using System;

namespace P_D109
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please m d");
            string input_abc = Console.ReadLine();
            
            int m;
            if(!int.TryParse(input_abc.Split(' ')[0] , out m)) return;
            if(m < 1 || m > 12) return;
            
            int d;
            if(!int.TryParse(input_abc.Split(' ')[1] , out d)) return;
            if(d < 1 || d > 31) return;

            string result = "No";

            string stringDate = m.ToString() + d.ToString();
            if(stringDate.Replace(stringDate[0].ToString(),"") == "")
            {
                result = "Yes";
            }

            Console.WriteLine(result);
        }
    }
}
