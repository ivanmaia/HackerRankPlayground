using System;

namespace SockMerchant
{
    class Program
    {

        static int sockMerchant(int n, int[] ar)
        {
            int[] socksByColor = new int[100];

            for (var i = 0; i < n; i++)
            {
                socksByColor[ar[i]-1]++;
            }

            decimal pairs = 0;
            for (var i = 0; i < socksByColor.Length; i++)
            {
                pairs += Math.Floor((decimal)(socksByColor[i]) / 2);
            }

            return Convert.ToInt32(pairs);
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
