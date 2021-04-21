using System;

namespace Matrixs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Матрицы!");
            Console.WriteLine("Выберете действие:");
            Console.WriteLine("1 - умножение матрицы на число;");
            Console.WriteLine("2 - сложение матриц;");
            Console.WriteLine("3 - вычитание матриц;");
            Console.WriteLine("4 - умножение двух матриц;");

            int mode;

            while (true)
            {
                try
                {
                    mode = Convert.ToInt32(Console.ReadLine());
                    if (mode >= 1 && mode <= 4)
                    {
                        break;
                    }
                    Console.WriteLine("Укажите число от 1 до 4 ");
                    Console.WriteLine("1 - умножение матрицы на число;");
                    Console.WriteLine("2 - сложение матриц;");
                    Console.WriteLine("3 - вычитание матриц;");
                    Console.WriteLine("4 - умножение двух матриц;");
                }
                catch
                {
                    Console.WriteLine("Укажите число от 1 до 4 ");
                    Console.WriteLine("1 - умножение матрицы на число;");
                    Console.WriteLine("2 - сложение матриц;");
                    Console.WriteLine("3 - вычитание матриц;");
                    Console.WriteLine("4 - умножение двух матриц;");
                }

            }
            Console.WriteLine(mode);

            //MakeMatrix Matrix = new MakeMatrix();

            //int[,] matrix = Matrix.makeMatrix();


            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine($"{matrix.GetLength(1)} число столбцов");
            //Console.WriteLine($"{matrix.GetLength(0)} число строк");

            ActionOnMatrix multiplierMatrix = new ActionOnMatrix();

            if (mode == 1)
            {
                multiplierMatrix.MyltiplaingMatrixOnNumber();
            }
            else if (mode == 2)
            {
                multiplierMatrix.AdditionMatrix();
            }
            else if (mode == 3)
            {
                multiplierMatrix.SubtractionMatrix();
            }
            else
            {
                multiplierMatrix.MultiplicationMatrix();
            }


        }
    }
}
