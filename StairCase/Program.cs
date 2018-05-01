using System;

namespace StairCase
{
    class Program
    {
        static void PlotStairCase(int n)
        {
            string step = "#";
            for (int i=0; i<n; i++){
                //Console.WriteLine("#".PadLeft(n-i,' ').PadRight(n,'#'));
                Console.WriteLine(step.PadLeft(n,' '));
                step = step+"#";
            }
        }
        
        static void Main(String[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            PlotStairCase(n);
        }
    }
}
