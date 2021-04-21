using System;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите до какого разряда вывести треугольник Паскаля?");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] treagle = new int[n + 1][];

            treagle[0] = new int[1];
            treagle[0][0] = 1;
            Console.WriteLine($"{treagle[0][0], 4}");

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    treagle[i] = new int[i + 1];
                    Console.WriteLine(treagle[i].Length);
                    for (int j = 0; j <= i; j++)
                    {
                        int firstTerm = 0;
                        int secondTerm = 0;
                        try
                        {
                            firstTerm = treagle[i - 1][j - 1];
                        }
                        catch {}
                        try
                        {
                            secondTerm = treagle[i - 1][j];
                        }
                        catch {}
                        treagle[i][j] = firstTerm + secondTerm;
                        Console.Write($"{treagle[i][j], 4}");
                    }
                    Console.Write("\n");
                }
            }
            Console.ReadKey();
        }
    }
}
