using System;

namespace P_D100
{
    
    class Program
    {
        public static int CountChar(string s, char c) {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("please input S");
            string input_line_1 = Console.ReadLine();

            int characterCount_1 = CountChar(input_line_1,'_');
            int characterCount_2 = CountChar(input_line_1,'-');

            string result = "";

            if((characterCount_1==characterCount_2)|| (characterCount_1>characterCount_2))
            {
                result = input_line_1.Replace("-","_");
            }
            else
            {
                result = input_line_1.Replace("_","-");
            }

            Console.WriteLine(result);
        }
    }
}
