using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void MinMaxSum(long[] arr)
    {
        long arrSum = arr.Sum();
        long min = arrSum;
        long max = 0;

        for (int except = 0; except < arr.Length; except++)
        {
            long lsum = arrSum - arr[except];
            if (lsum > max) max = lsum;
            if (lsum < min) min = lsum;
        }

        Console.WriteLine("{0} {1}", min, max);
    }

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(arr_temp,Int64.Parse);
        MinMaxSum(arr);
    }
}
