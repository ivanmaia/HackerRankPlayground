using System;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input_line_one = Console.ReadLine().Split(' ');
            string[] input_line_two = Console.ReadLine().Split(' ');
            int b_charged = int.Parse(Console.ReadLine());

            int n = int.Parse(input_line_one[0]);
            int k = int.Parse(input_line_one[1]);

            double b_actual = 0;

            for (var i=0; i<n; i++)
            {
                if (i != k) b_actual += double.Parse(input_line_two[i])/2;
            }

            if (b_actual == b_charged)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b_charged - b_actual);
            }

            Console.ReadKey();

        }
    }
}
