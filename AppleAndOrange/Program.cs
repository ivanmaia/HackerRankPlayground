using System;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(String[] args) {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp,Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp,Int32.Parse);

            int fruitsLC = 0;
            if (apple.Length > orange.Length) 
                fruitsLC = apple.Length;
            else
                fruitsLC = orange.Length;
            
            int loopControl = 0;
            int applesInSamsHouse = 0;
            int orangesInSamsHouse = 0;
            while (loopControl < fruitsLC)
            {
                if (loopControl < apple.Length)
                {
                    //Console.WriteLine("Apple m{0} - distance from a:{1} - landing point:{2}", loopControl, apple[loopControl], apple[loopControl]+a);
                    if (apple[loopControl]+a >= s && apple[loopControl]+a <=t){
                        //Console.WriteLine("Apple m{0} lands in Sams house.", loopControl);
                        applesInSamsHouse++;
                    }
                }

                if (loopControl < orange.Length)
                {
                    //Console.WriteLine("Orange n{0} - distance from b:{1} - landing point:{2}", loopControl, orange[loopControl], orange[loopControl]+b);
                    if (orange[loopControl]+b >= s && orange[loopControl]+b <=t){
                        //Console.WriteLine("Orange n{0} lands in Sams house.", loopControl);
                        orangesInSamsHouse++;
                    }
                }
                loopControl++;
            }
            Console.WriteLine(applesInSamsHouse);
            Console.WriteLine(orangesInSamsHouse);
        }
    }
}
