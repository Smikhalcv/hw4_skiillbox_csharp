using System;

namespace CSharp_HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] report = new int[12, 4];
            int[] profit = new int[12];
            int[] minProfit = new int[3];

            // создаёт таблицу и заполняет массив прибыли для обработки информации
            for (int i = 0; i < report.GetLength(0); i++)
            {
                report[i, 0] = i + 1;
                report[i, 1] = random.Next(10_000, 1_000_001);
                report[i, 2] = random.Next(10_000, 1_000_001);
                report[i, 3] = report[i, 1] - report[i, 2];
                profit[i] = report[i, 3];
            }

            // сортирует массив прив прибыли
            Array.Sort(profit);

            // выбирает 3 первых(минимальных) значения из массива прибыли
            Array.Copy(profit, minProfit, 3);

            // Сортирует массив из самых низких цен на случай дублирования результатов
            for (int i = 3; i < profit.Length; i++)
            {
                if (profit[i] < minProfit[2] && profit [i] > minProfit[1])
                {
                    minProfit[2] = profit[i];
                }
                else if (profit[i] < minProfit[1] && profit[i] > minProfit[0])
                {
                    int k = minProfit[1];
                    minProfit[1] = profit[i];
                    minProfit[2] = k;
                }
                
            }


            // та прибыль ниже которой входит в 3 минимальных
            int boardlineProfit = minProfit[2];


            // выводит таблицу изменяя цвет на крассны если прибыль в топ 3 снизу
            for (int i = 0; i < report.GetLength(0); i++)
            {
                if (report[i, 3] <= boardlineProfit)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"Номер месяца: {report[i, 0],2}, " +
                    $"Доход: {report[i, 1],8}, " +
                    $"Расходы: {report[i, 2],8}, " +
                    $"Прибыль: {report[i, 3],8}.");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
