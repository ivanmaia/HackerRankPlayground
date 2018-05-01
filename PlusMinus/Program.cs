using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static void SolveIt(int[] arr) { 
        int positives = 0;
        int negatives = 0;
        int zeroes = 0;
        for (int i=0; i<arr.Length; i++){
            if (arr[i] == 0){
                zeroes++;
            } else {
                if ( arr[i] > 0)
                    positives++;
                else
                    negatives++;
            }
        }
        /*
        Console.WriteLine(positives);
        Console.WriteLine(negatives);
        Console.WriteLine(zeroes);
        Console.WriteLine(arr.Length);
        */
        
        Console.WriteLine("{0:N6}",positives/(float)(arr.Length));
        Console.WriteLine("{0:N6}",negatives/(float)(arr.Length));
        Console.WriteLine("{0:N6}",zeroes/(float)(arr.Length));
        
        /*
        Console.WriteLine(Math.Round((double)(positives/arr.Length),6));
        Console.WriteLine(Math.Round((double)(negatives/arr.Length),6));
        Console.WriteLine(Math.Round((double)(zeroes/arr.Length),6));
        */
    }
    
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        SolveIt(arr);
    }
}
