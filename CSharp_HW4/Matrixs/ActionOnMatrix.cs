using System;
using System.Collections.Generic;
using System.Text;

namespace Matrixs
{
    class ActionOnMatrix
    {
        /// <summary>
        /// Умножает матрицу на число.
        /// </summary>
        public void MyltiplaingMatrixOnNumber()
        {
            Console.WriteLine("Умножение матрицы на число.");
            MakeMatrix Matrix = new MakeMatrix();
            int[,] matrix = Matrix.makeMatrix();
            Console.WriteLine("Введите число, на которое нужно умножить матрицу - ");
            int multiplier;
            while (true)
            {
                try
                {
                    multiplier = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            // Заполнение итоговой матрицы
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] * multiplier;
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Сумма матриц.
        /// </summary>
        public void AdditionMatrix()
        {
            Console.WriteLine("Сложение матриц.");
            MakeMatrix matrix = new MakeMatrix();
            int[,] matrix1;
            int[,] matrix2;

            while (true) // Создание матриц и проверка их на пригодность
            {
                Console.WriteLine("Создание первой матрицы");
                matrix1 = matrix.makeMatrix();
                Console.WriteLine("Создание второй матрицы");
                matrix2 = matrix.makeMatrix();

                if (matrix1.Rank == matrix2.Rank && 
                    matrix1.GetLength(0) == matrix2.GetLength(0) &&
                    matrix1.GetLength(1) == matrix2.GetLength(1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Эти матрицы нельзя сложить.");
                    Console.WriteLine("Матрицы должны быть одного порядка, иметь одинаковое количество строк и столбцов.");
                }
            }

            int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            // Заполнение итоговой матрицы
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(0); j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write($"{resultMatrix[i,j], 4}");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Вычитание матриц.
        /// </summary>
        public void SubtractionMatrix()
        {
            Console.WriteLine("Вычитание матриц.");
            MakeMatrix matrix = new MakeMatrix();
            int[,] matrix1;
            int[,] matrix2;

            while (true) // Создание матриц и проверка их на пригодность
            {
                Console.WriteLine("Создание первой матрицы");
                matrix1 = matrix.makeMatrix();
                Console.WriteLine("Создание второй матрицы");
                matrix2 = matrix.makeMatrix();

                if (matrix1.Rank == matrix2.Rank &&
                    matrix1.GetLength(0) == matrix2.GetLength(0) &&
                    matrix1.GetLength(1) == matrix2.GetLength(1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Эти матрицы нельзя вычесть.");
                    Console.WriteLine("Матрицы должны быть одного порядка, иметь одинаковое количество строк и столбцов.");
                }
            }

            int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            // Заполнение итоговой матрицы
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(0); j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                    Console.Write($"{resultMatrix[i, j],4}");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Умножение матриц.
        /// </summary>
        public void MultiplicationMatrix()
        {
            Console.WriteLine("Умножение матриц.");
            MakeMatrix matrix = new MakeMatrix();
            int[,] matrix1;
            int[,] matrix2;

            while (true) // Создание матриц и проверка их на пригодность
            {
                Console.WriteLine("Создание первой матрицы");
                matrix1 = matrix.makeMatrix();
                Console.WriteLine("Создание второй матрицы");
                matrix2 = matrix.makeMatrix();

                if (matrix1.GetLength(1) == matrix2.GetLength(0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Эти матрицы нельзя перемножить.");
                    Console.WriteLine("Число столбцов первой матрицы, должно быть равно числу строк второй.");
                }
            }

            int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = 0;

                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                    Console.Write($"{resultMatrix[i, j],6}");
                }
                Console.WriteLine();
            }

        }
    }
}
