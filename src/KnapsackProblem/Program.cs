using System;
using System.Collections.Generic;
using System.IO;

namespace KnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFile = @"C:\Users\Анна\Desktop\KSP.txt";
            string[] readText = File.ReadAllLines(pathFile);
            var valueArray = new List<int>();
            var itemsList1 = new List<Item>();
            for (int i = 0; i < readText.Length-1; i++)
            {
                string[] nums = readText[i].Split(' ');
                foreach (string n in nums)
                {
                    int value;
                    if (int.TryParse(n, out value))
                    {
                        valueArray.Add(value);
                    }
                }
                var item = new Item(valueArray[1], valueArray[2]); //создать объект и очистить лист
                itemsList1.Add(item);
                valueArray.Clear();
            }
            string[] nums2 = readText[readText.Length-1].Split(' ');
            foreach (string n in nums2)
            {
                int value;
                if (int.TryParse(n, out value))
                {
                    valueArray.Add(value);
                }
            }
            var knapsack1 = new Knapsack(valueArray[0]);//создать объект и очистить лист
            valueArray.Clear();

            /*Item item1 = new Item(30,20);
            itemsList1.Add(item1);
            Item item2 = new Item(40,40);
            itemsList1.Add(item2);
            Item item3 = new Item(60,50);
            itemsList1.Add(item3);
            Item item4 = new Item(15,10);
            itemsList1.Add(item4);
            Item item5 = new Item(10,5);
            itemsList1.Add(item5);*/
            Console.WriteLine("------------------------------");
            Console.WriteLine("Жадный алгоритм задачи о ранце");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            for (int i = 0; i < itemsList1.Count; i++)
            {
                Console.WriteLine("Предмет " + i + " с весом " + itemsList1[i].weight + " и стоимостью " + itemsList1[i].price);
            }
            Console.WriteLine("Максимальный вес ранца: " + knapsack1.getMaxWeight());
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            knapsackProblemMethod(ref knapsack1, ref itemsList1);
            Console.ReadKey(true);
            
        }
        static void knapsackProblemMethod(ref Knapsack knapsack, ref List<Item> itemslist)
        {
            int maxItemPrice = 0, select = 0, step = 0;
            bool result = true;
            while (result == true)
            {
                for (int i = 0; i < itemslist.Count; i++)//выбор наибольшей ценности
                {
                    if (itemslist[i].price > maxItemPrice && !itemslist[i].wasTaken)
                    {
                        maxItemPrice = itemslist[i].price;
                        select = i;
                    }
                }
                result = knapsack.checkMaxWeight(itemslist[select].weight);//проверка на весовое ограничение
                if (result)
                {
                    knapsack.foldItem(itemslist[select]);
                    Console.WriteLine("Номер шага: " + step);
                    Console.WriteLine();
                    Console.WriteLine("Порядковый номер выбранного предмета(начиная с 0): " + select);
                    Console.WriteLine("Стоимость выбранного предмета: " + maxItemPrice);
                    Console.WriteLine("Вес выбранного предмета: " + itemslist[select].weight);
                    Console.WriteLine("Текущая цена ранца: " + knapsack.totalValue);
                    Console.WriteLine("Текущий вес ранца: " + knapsack.currentWeight);
                    Console.WriteLine();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine();
                }
                maxItemPrice = 0;//сброс значения
                step++;
            }
            Console.WriteLine("Итоговое решение:");
            Console.WriteLine();
            Console.WriteLine("Текущая цена ранца: " + knapsack.totalValue);
            Console.WriteLine("Текущий вес ранца: " + knapsack.currentWeight);
            Console.WriteLine("Предметы (взятые - 1, не взятые - 0): " );
            for (int i = 0; i < itemslist.Count; i++)
            {
                if (itemslist[i].wasTaken)
                {
                    Console.WriteLine(i + " - 1");
                }
                else
                {
                    Console.WriteLine(i + " - 0");
                }
            }
        }
    }
}
