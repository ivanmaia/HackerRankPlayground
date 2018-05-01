using System;
using System.Collections.Generic;
using System.IO;

namespace YetAnotherMinimaxProblem
{
    class Solution {

        private static void Print(int[] v, int s){
            for (int i = 0; i < s; i++){
                Console.Write("{0} ", v[i]);
            }
            Console.WriteLine(" ");
        }

        private static int ComputeMinScore(int[] v, int s){
            int minScore = Int32.MaxValue;
            int maxScore = 0;
            string tupleMax = "({0}, {1})";
            for (int i = 0; i < s-1; i++){
                if (minScore > (v[i]^v[i+1]))
                    minScore = (v[i]^v[i+1]);
                if (maxScore < (v[i]^v[i+1])){
                    maxScore = (v[i]^v[i+1]);
                    tupleMax = String.Format("({0}, {1})",v[i], v[i+1]);
                }
            }
            Console.WriteLine("Min Score: {0} ", minScore);
            Console.WriteLine("Max Score: {0} ", maxScore);
            Console.WriteLine(tupleMax);
            return minScore;
        }

        private static void Permute(int[] v, int start, int n){
            if (start == n-1) {
                Print(v, n);
                ComputeMinScore(v, n);
            }
            else {
                for (int i = start; i < n; i++) {
                int tmp = v[i];
                
                v[i] = v[start];
                v[start] = tmp;
                Permute(v, start+1, n);
                v[start] = v[i];
                v[i] = tmp;
                }
            }
        }

        private static int SolveIt(int[] arr){
            Permute(arr, 0, arr.Length);
            return 5;
        }

        static void Main(String[] args) {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
            SolveIt(arr);
            
        }
    }
}
