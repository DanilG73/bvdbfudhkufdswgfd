using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp666
{
    class Program
    {
        static void Main(string[] args)
        {
            again:
            Console.Write("Введте номер задачи: ");
            int pr = int.Parse(Console.ReadLine());
            switch (pr)
            {
                case 1:
                    {
                        Console.WriteLine("Во время сильного дождя на остановке стояло 12 человек. Подкативший автобус забрызгал грязью 4-го, 5-го, 6, 7 и 8-го человека. Остальные попрыгали в колючие кусты, причем 3-ий, 9-ый и 12-ый так и не смогли выбраться из них. Задать номер пассажира и определить грязный он или исцарапанный.");
                        Console.WriteLine("На остановке стоит 12 человек");
                        int a = int.Parse(Console.ReadLine());
                        if (a >= 4 && a <= 8)
                        {
                            Console.WriteLine("едет в автобусе ,и он грязный ");
                        }
                        else if (a == 3 || a == 9 || a == 12)
                        {
                            Console.WriteLine("он в кустах");
                        }
                        else if (a == 1 || a == 2 || a == 10 || a == 11)
                        {
                            Console.WriteLine("едет в автобусе и поцарапаный");
                        }
                        else
                        {
                            Console.WriteLine("Данного пасажира не существует на остановке.ВВЕДИТЕ ИМЕННО ЧИСЛО ОТ 1 ДО 12!");
                        }
                        goto again;
                    }

                    
                case 2:
                    {
                        Console.WriteLine("В трехзначном числе х зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа х, то получилось число 456. Найти число х");
                        Console.Write("Введите трехзначное число: ");
                        int x = int.Parse(Console.ReadLine());
                        int a1 = x / 100;
                        int b = x / 10 % 10;
                        int d = x % 10;
                        x = a1 * 100 + d * 10 + b;
                        Console.Write($"{x}");
                        goto again;
                    }
            }
        }
        
        
        
    }
}
