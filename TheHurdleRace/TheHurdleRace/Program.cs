using System;

class Program
{
    static int hurdleRace(int k, int[] height)
    {
        if (k == 100) return 0;

        var maxHeight = 0;
        for (var i=0; i< height.Length; i++)
        {
            if (height[i] == 100)
            {
                maxHeight = 100;
                break;
            }
            maxHeight = (maxHeight < height[i]) ? height[i] : maxHeight;
        }

        return ((maxHeight < k) ? 0 : maxHeight-4);
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp, Int32.Parse);
        int result = hurdleRace(k, height);
        Console.WriteLine(result);
        Console.ReadKey();
    }

}
