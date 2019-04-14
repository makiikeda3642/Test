using System;

namespace P_D094
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter_dog = 0;
            int counter_cat = 0;

            for(int i=0; i<3; i++)
            {
                string input_line = Console.ReadLine();

                if(input_line == "dog")
                {
                    counter_dog++;
                }
                else if(input_line == "cat")
                {
                    counter_cat++;
                }
            }

            Console.WriteLine(counter_dog > counter_cat ? "dog" : "cat");
        }
    }
}
