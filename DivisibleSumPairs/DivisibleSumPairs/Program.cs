﻿
using System;

class Program
{
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        // Complete this function
        var numberOfPairs = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {

                if (j >= i) break;

                if ((ar[i] + ar[j]) % k == 0) numberOfPairs++;

            }
        }

        return numberOfPairs;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}

