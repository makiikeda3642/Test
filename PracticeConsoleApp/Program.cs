using System;

namespace P_D092
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("please input");
            string input_line_1 = Console.ReadLine();
            double x_1;
            if(!double.TryParse(input_line_1.Split(' ')[0] , out x_1)) return;
            if(x_1 < 1 || x_1 > 30) return;

            double y_1;
            if(!double.TryParse(input_line_1.Split(' ')[1] , out y_1)) return;
            if(y_1 < 1 || y_1 > 30) return;

            double p_1;
            if(!double.TryParse(input_line_1.Split(' ')[2] , out p_1)) return;
            if(p_1 < 1000 || p_1 > 50000) return;

            string input_line_2 = Console.ReadLine();
            double x_2;
            if(!double.TryParse(input_line_2.Split(' ')[0] , out x_2)) return;
            if(x_2 < 1 || x_2 > 30) return;

            double y_2;
            if(!double.TryParse(input_line_2.Split(' ')[1] , out y_2)) return;
            if(y_2 < 1 || y_2 > 30) return;

            double p_2;
            if(!double.TryParse(input_line_2.Split(' ')[2] , out p_2)) return;
            if(p_2 < 1000 || p_2 > 50000) return;

            double price_sheet1 = p_1/(x_1*y_1);
            double price_sheet2 = p_2/(x_2*y_2);
            
            string result = "";
            //Console.WriteLine(price_sheet1);
            //Console.WriteLine(price_sheet2);
            if(price_sheet1 == price_sheet2)
            {
                result = "DRAW";
            }
            else if(price_sheet1 < price_sheet2)
            {
                result = input_line_1;
            }
            else
            {
                result = input_line_2;
            }

            Console.WriteLine(result);
        }
    }
}
