using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> citiesList = new List<City>();
            Random rnd = new Random();
            double[,] Matrix = new double[5, 5];
            List<int> Path = new List<int>();
            double totalDistance = 0;
            
            City city0 = new City(10,5);
            citiesList.Add(city0);
            City city1 = new City(30, 15);
            citiesList.Add(city1);
            City city2 = new City(22, 40);
            citiesList.Add(city2);
            City city3 = new City(3, 27);
            citiesList.Add(city3);
            City city4 = new City(16, 20);
            citiesList.Add(city4);

            for (int i = 0; i < 5; i++) //заполнение матрицы расстояний
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix[i, j] = calcCityDistance(citiesList[i],citiesList[j]);
                }
            }
            nearestNeighborsMethod(citiesList);

            void nearestNeighborsMethod(List<City> citieslist)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Метод ближайшего соседа");
                Console.WriteLine("-----------------------");
                Console.WriteLine();
                Console.WriteLine("Матрица расстояний городов:");
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0,-20} ", i + " город");
                }
                Console.Write("\n");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0,-20} ", "_");
                }
                Console.Write("\n");
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("{0,-20} ", Matrix[i, j]);
                    }
                    Console.Write("{0,-20} ", "| " + i + " город");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                Console.WriteLine();
                int Exit = 1;
                while (Exit == 1)
                {
                    int selectedCity = rnd.Next(0, 5);//выбор 1 случайного города
                    citiesList[selectedCity].wasVisited = true;
                    int step = 0;
                    Console.WriteLine("Номер шага: " + step);
                    Console.WriteLine();
                    Console.WriteLine("Первый случайно выбранный город: " + selectedCity);
                    Console.Write("Начало пути: ");
                    Path.Add(selectedCity);
                    for (int i = 0; i < Path.Count; i++)
                    {
                        Console.Write(Path[i] + " ");
                    }
                    Console.Write("\n");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------");
                    Console.WriteLine();
                    step++;

                    while (step < citiesList.Count)
                    {
                        int nearestCity = -1;
                        double minDist = 999;
                        Console.WriteLine("Номер шага: " + step);
                        Console.WriteLine();
                        for (int i = selectedCity; i < selectedCity + 1; i++)
                        {
                            for (int j = 0; j < 5; j++)//просматриваем расстояния от выбранного до других
                            {
                                if (Matrix[i, j] < minDist && !citiesList[j].wasVisited)
                                {
                                    minDist = Matrix[i, j];
                                    nearestCity = j;
                                }
                            }
                        }
                        totalDistance += minDist;
                        citiesList[nearestCity].wasVisited = true;
                        Console.WriteLine("Ближайший город: " + nearestCity);
                        Console.WriteLine("Расстояние от текущего города " + selectedCity + " до ближайшего " + nearestCity + ": " + minDist);
                        Console.WriteLine("Общее расстояние: " + totalDistance);
                        Path.Add(nearestCity);
                        Console.Write("Пройденный путь: ");
                        for (int i = 0; i < Path.Count; i++)
                        {
                            Console.Write(Path[i] + " ");
                        }
                        Console.Write("\n");
                        Console.WriteLine();
                        Console.WriteLine("-----------------------");
                        Console.WriteLine();
                        selectedCity = nearestCity;
                        step++;
                    }
                    for (int i = 0; i < citiesList.Count; i++)
                    {
                        citiesList[i].wasVisited = false; //сброс флагов
                    }
                    totalDistance = 0; //сброс дистанции
                    Path.Clear();
                    Console.WriteLine("Для повтора программы нажмите 1, для выхода нажмите 0: ");
                    Exit = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            double calcCityDistance(City A, City B)
            {
                double xVal = Math.Pow(B.X - A.X, 2);
                double yVal = Math.Pow(B.Y - A.Y, 2);
                double dist = Math.Sqrt(xVal + yVal);
                return dist;
            }
        }
    }
}
