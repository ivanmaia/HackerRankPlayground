using System;

namespace BigSorting
{
    class Program
    {


        static void swap (string[] arr, int a, int b)
        {
            string temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        static int partition(string[] arr, int low,
                                   int high)
        {
            int pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    swap(arr, i, j);
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }



        /*
         * Complete the bigSorting function below.
         */
        static string[] bigSorting(string[] unsorted)
        {
            /*
             * Write your code here.
             */
            return new string[1];
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] unsorted = new string[n];

            for (int unsortedItr = 0; unsortedItr < n; unsortedItr++)
            {
                string unsortedItem = Console.ReadLine();
                unsorted[unsortedItr] = unsortedItem;
            }

            string[] result = bigSorting(unsorted);

            Console.WriteLine(string.Join("\n", result));

        }
    }
}
