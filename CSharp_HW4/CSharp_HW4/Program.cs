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

            string columnMonth = "Месяц";
            string columnRevenue = "Доходы";
            string columnExpenses = "Расходы";
            string columnProfit = "Прибыль";
            Console.WriteLine($"{columnMonth, 6}:{columnRevenue, 8}:{columnExpenses, 8}:{columnProfit, 8}:");

            int counterPozitiveProfit = 0;
            // выводит таблицу изменяя цвет на крассны если прибыль в топ 3 снизу
            for (int i = 0; i < report.GetLength(0); i++)
            {
                if (report[i, 3] <= boardlineProfit)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"{report[i, 0],6}" +
                    $"{report[i, 1],9}" +
                    $"{report[i, 2],9}" +
                    $"{report[i, 3],9}");
                Console.ResetColor();
                if (report[i, 3] > 0)
                {
                    counterPozitiveProfit++;
                }
            }
            Console.WriteLine($"Количество месяцев с положительной прибылью - {counterPozitiveProfit}");

            Console.ReadKey();
        }
    }
}
