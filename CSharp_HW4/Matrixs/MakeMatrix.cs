using System;
using System.Collections.Generic;
using System.Text;

namespace Matrixs
{
    class MakeMatrix
    {
        /// <summary>
        /// Создаёт матрицу.
        /// </summary>
        /// <returns></returns>
        public int[,] makeMatrix()
        {
            int numberRows;
            int numberColumns;

            Console.WriteLine("Редактор матриц");
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Укажите количество строк - ");
                        numberRows = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception) { }
                } // создание матрицы количество строк
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Укажите количество столбцов - ");
                        numberColumns = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception) { }
                } // создание матрицы количество столбцов

                int[,] matrix = new int[numberRows, numberColumns];

                for (int i = 0; i < matrix.GetLength(0); i++) // Заполнение матрицы
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine($"Укажите элемент матрицы строки номер {i} столбца номер {j} - ");
                                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }

                    }
                }
                Console.WriteLine("Если матрица создана верно, введите Создать.");
                Console.WriteLine("Если матрица создана не верно, введите Пересоздать.");
                string access;
                access = Console.ReadLine();
                if (access.Trim().ToLower() == "пересоздать")
                {
                    continue;
                }
                return matrix;
            }

        }


    }
}
