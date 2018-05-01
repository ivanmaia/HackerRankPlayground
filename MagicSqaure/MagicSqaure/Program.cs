using System;

namespace MagicSqaure
{

    class Program
    {

        static int formingMagicSquare(int[][] s)
        {
            // Complete this function
            int[] cts = {0,0,0,0,0,0,0,0};
            int[][] allMagicSquares = {
                new int[] {8,1,6,3,5,7,4,9,2},
                new int[] {6,1,8,7,5,3,2,9,4},
                new int[] {4,9,2,3,5,7,8,1,6},
                new int[] {2,9,4,7,5,3,6,1,8},
                new int[] {8,3,4,1,5,9,6,7,2},
                new int[] {4,3,8,9,5,1,2,7,6},
                new int[] {6,7,2,1,5,9,8,3,4},
                new int[] {2,7,6,9,5,1,4,3,8},
            };

            for (int i = 0; i < 8; i++)
            {
                var sIndex = 0;
                for (int j = 0; j < 7; j += 3)
                {
                    cts[i] += Math.Abs(allMagicSquares[i][j] - s[sIndex][0]) + Math.Abs(allMagicSquares[i][j+1] - s[sIndex][1]) + Math.Abs(allMagicSquares[i][j+2] - s[sIndex][2]);
                    sIndex++;
                }
                /*
                costs[i] = Math.Abs(allMagicSquares[i][0] - s[0][0]) + Math.Abs(allMagicSquares[i][1] - s[0][1]) + Math.Abs(allMagicSquares[i][2] - s[0][2]);
                costs[i] = costs[i] + Math.Abs(allMagicSquares[i][3] - s[1][0]) + Math.Abs(allMagicSquares[i][4] - s[1][1]) + Math.Abs(allMagicSquares[i][5] - s[1][2]);
                costs[i] = costs[i] + Math.Abs(allMagicSquares[i][6] - s[2][0]) + Math.Abs(allMagicSquares[i][7] - s[2][1]) + Math.Abs(allMagicSquares[i][8] - s[2][2]);
                */
            }

            Array.Sort(cts);

            return cts[0];
        }

        static void Main(String[] args)
        {
            int[][] s = new int[3][];
            for (int s_i = 0; s_i < 3; s_i++)
            {
                string[] s_temp = Console.ReadLine().Split(' ');
                s[s_i] = Array.ConvertAll(s_temp, Int32.Parse);
            }
            int result = formingMagicSquare(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
