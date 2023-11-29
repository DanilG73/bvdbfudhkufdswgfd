using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp555
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int po = int.Parse(Console.ReadLine());
            switch (po)
            {
                case 1:
                    Console.Write("Введите количество дней: ");
            int n = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(2000, 1, 1).AddDays(n);

            Console.WriteLine($"Текущий месяц: {date.ToString("MMMM")}");
            break;
                case 2:
                    int[,] goals = new int[11, 3] { { 1, 2,0 }, { 0, 0, 0 },
                    { 2, 0, 0 }, { 1, 0, 1 }, { 0, 3, 0}, { 0, 1, 0 },
                    { 3, 0, 0 }, { 2, 2, 0}, {0, 2, 0 }, { 4, 0, 2 }, {0 , 0, 1 } };

                    int rows = goals.GetUpperBound(0) + 1;
                    int columns = goals.Length / rows;
                    int count = 0;
                    int goalSum = 0;

                    for (int i = 0; i < rows; i++)
                    {
                        goalSum = 0;
                        for (int j = 0; j < columns; j++)
                        {
                            goalSum += goals[i, j];

                        }

                        if (goalSum >= 2)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine($"Число футблоистов, забивших хотя бы два гола: {count}");
                    break;
        }
        Console.ReadKey();
                                
        }
    }
}
