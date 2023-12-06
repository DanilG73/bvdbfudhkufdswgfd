using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp777
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Введте номер задачи: ");
                int pr = int.Parse(Console.ReadLine());
                switch (pr)
                {
                    case 1:
                        {
                            Console.Write("Введите значение а: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Введите значение b:");
                            int b = int.Parse(Console.ReadLine());
                            for (int i = b; i >= a; i--)
                            {
                                Console.WriteLine(Math.Pow(i, 3));
                            }
                            
                        }
                    break;
                    case 2:
                    {
                        for (int i = 1; i <= 1; ++i,
                        Console.WriteLine())
                            for (int j = 1; j <= 1; ++j)
                                Console.Write(" " + 1);
                        for (int i = 1; i <= 1; ++i,
                        Console.WriteLine())
                            for (int j = 1; j <= 2; ++j)
                                Console.Write(" " + 2);
                        for (int i = 1; i <= 1; ++i,
                        Console.WriteLine())
                            for (int j = 1; j <= 3; ++j)
                                Console.Write(" " + 3);
                        for (int i = 1; i <= 1; ++i,
                        Console.WriteLine())
                            for (int j = 1; j <= 4; ++j)
                                Console.Write(" " + 4);
                        for (int i = 1; i <= 1; ++i,
                        Console.WriteLine())
                            for (int j = 1; j <= 5; ++j)
                                Console.Write(" " + 5);

                    }
                    break;
                    case 3:
                        {
                            Console.Write("Введите значение а: ");
                            int a1 = int.Parse(Console.ReadLine());
                            Console.Write("Введите значение b:");
                            int b2 = int.Parse(Console.ReadLine());
                            int sum = 0;
                            if (a1 > b2)
                            {
                                Console.WriteLine("Число a больше чем b, некоректное высказывание");
                            }
                            else
                            {

                                for (int i = a1; i <= b2; i++)
                                {
                                    sum += i * i;
                                }
                            Console.WriteLine($"{sum}");
                            }
                 
                        break;
                        }
                }
            Console.ReadKey();
            
        }
    }
}
