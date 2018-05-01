using System;
using System.Collections.Generic;

namespace PickingNumbers
{
    class Program
    {

        List<String> sequences = new List<String>();

        static bool Test(int a, int b)
        {
            var test = (a - b);
            return (test >= -1 && test <= 1);
        }

        static int pickingNumbers(int[] a)
        {
            // Complete this function
            int sequenceCount = 0;
            for (var i = 0; i < a.Length; i++)
            {
                int[] itSequence = new int[a.Length];
                int itSequenceCount = 1;
                bool accept = false;
                itSequence[0] = a[i];
                for (var j = 0; j < a.Length; j++)
                {
                    if (i != j && Test(a[i], a[j]))
                    {
                        for (var k = 0; k < itSequenceCount; k++)
                        {
                            accept = (Test(a[j], itSequence[k]));
                            if (!accept) break;
                        }

                        if (accept)
                        {
                            itSequenceCount++;
                            itSequence[itSequenceCount-1] = a[j];
                        }
                    }
                }
                if (itSequenceCount > sequenceCount) sequenceCount = itSequenceCount;
            
            }
            return (sequenceCount);
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int result = pickingNumbers(a);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
