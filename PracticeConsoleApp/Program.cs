using System;

namespace P_D097
{
    class Program
    {
        public static int CountChar(string s, char c) {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please input");
            string input_line_1 = Console.ReadLine();

            int have_I = CountChar(input_line_1,'I') > 0 ? 1:0;
            int have_l = CountChar(input_line_1,'l') > 0 ? 1:0;
            int have_i = CountChar(input_line_1,'i') > 0 ? 1:0;

            string result = input_line_1;

            if((have_I + have_l + have_i) >= 2)
            {
                result = "caution";
            }

            Console.WriteLine(result);
        }
    }
}
