using System;

class Solution
{

    static int designerPdfViewer(int[] h, string word)
    {
        // Complete this function
        char[] worArr = word.ToCharArray();
        var maxH = 0;
        for (var i = 0; i < word.Length; i++)
        {
            var index = worArr[i] - 97;
            if (maxH < h[index]) maxH = h[index];
        }
        return worArr.Length * 1 * maxH;
    }

    static void Main(String[] args)
    {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp, Int32.Parse);
        string word = Console.ReadLine();
        int result = designerPdfViewer(h, word);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}

