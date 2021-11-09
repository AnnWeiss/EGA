using System;
using System.Collections.Generic;

namespace EGA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> candidateList = new List<Candidate>();
            Random rnd = new Random();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Выбор лучшего решения методом Монте-Карло");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Введите длину кодировки: ");
            int lengthEncode = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ландшафт (кол-во кодировок): ");
            int landscape = int.Parse(Console.ReadLine());

            for (int i = 0; i < landscape; i++)
            {
                Candidate objCand = new Candidate(lengthEncode);
                for (int j = 0; j < lengthEncode; j++)
                {
                    objCand.encoding[j] = rnd.Next(2); //задается случайная кодировка
                }
                objCand.fitness = rnd.Next(1, landscape + 1); //задается случайная приспособленность
                candidateList.Add(objCand);
            }

            Console.WriteLine("Кодировки созданы! Созданный ландшафт: ");
            Console.WriteLine();
            for (int i = 0; i < landscape; i++)
            {
                Console.Write(string.Join("", candidateList[i].encoding));
                Console.Write(" ");
                Console.Write(string.Join("", candidateList[i].fitness));
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Введите количество проверок кандидата: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("Метод Монте-Карло: ");
            Console.WriteLine("------------------");

            int max = 0; //максимум приспособленности
            int maxS = -1; //пустой вектор (индекс в листе)
            int Exit = 1;
            while (Exit == 1)
            {
                for (int i = 0; i < N; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Номер шага: " + i);
                        maxS = rnd.Next(candidateList.Count); //случайный выбор вектора (запоминаем индекс)
                        max = candidateList[maxS].fitness; //запоминаем приспособленность
                        Console.WriteLine("Первая случайная кодировка: " + string.Join("", candidateList[maxS].encoding));
                        Console.WriteLine("Текущий максимум приспособленности: " + max);
                        Console.WriteLine();
                        Console.WriteLine("------------------");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Номер шага: " + i);
                        int maxSNext = rnd.Next(candidateList.Count);
                        int maxNext = candidateList[maxSNext].fitness;
                        Console.WriteLine("Выбираемая на шаге кодировка: " + string.Join("", candidateList[maxSNext].encoding));
                        Console.WriteLine("Приспособленность выбираемой на шаге кодировки: " + maxNext);

                        if (maxNext > max)
                        {
                            Console.WriteLine("Смена максимума!");
                            max = maxNext;
                            maxS = maxSNext;
                            Console.WriteLine("Текущая лучшая кодировка: " + string.Join("", candidateList[maxS].encoding));
                            Console.WriteLine("Текущий максимум приспособленности: " + max);
                            Console.WriteLine();
                            Console.WriteLine("------------------");
                        }
                        else
                        {
                            Console.WriteLine("Максимум не меняется");
                            Console.WriteLine("Текущая лучшая кодировка: " + string.Join("", candidateList[maxS].encoding));
                            Console.WriteLine("Текущий максимум приспособленности: " + max);
                            Console.WriteLine();
                            Console.WriteLine("------------------");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Для повтора программы нажмите 1, для выхода нажмите 0: ");
                Exit = int.Parse(Console.ReadLine());
            }
        }
    }
}
