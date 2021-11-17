using System;
using System.Collections.Generic;

namespace TravellingSalesmanProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var citiesList = new List<City>();
            
            //double[,] Matrix = new double[5, 5];
            /*City city0 = new City(10, 5);
            citiesList.Add(city0);
            City city1 = new City(30, 15);
            citiesList.Add(city1);
            City city2 = new City(22, 40);
            citiesList.Add(city2);
            City city3 = new City(3, 27);
            citiesList.Add(city3);
            City city4 = new City(16, 20);
            citiesList.Add(city4);*/
            double[,] Matrix2 = new double[15, 15]
            {
                {0.00, 6.08, 11.00, 10.20, 9.22, 10.05, 12.37, 13.89, 12.17, 3.16, 5.10, 7.07, 13.42, 13.60, 1.41},
                {6.08, 0.00, 13.42, 5.00, 12.81, 13.04, 13.34, 13.04, 13.60, 3.00, 1.00, 1.00, 13.00, 12.17, 5.00},
                {11.00, 13.42, 0.00, 13.45, 2.83, 1.41, 3.16, 7.07, 2.24, 12.37, 13.00, 13.89, 6.08, 8.00, 12.04},
                {10.20, 5.00, 13.45, 0.00, 13.89, 13.60, 12.21, 10.44, 12.81, 7.62, 5.83, 4.24, 10.77, 9.22, 9.49},
                {9.22, 12.81, 2.83, 13.89, 0.00, 1.41, 5.83, 9.49, 5.00, 11.18, 12.21, 13.45, 8.54, 10.20, 10.44},
                {10.05, 13.04, 1.41, 13.60, 1.41, 0.00, 4.47, 8.25, 3.61, 11.70, 12.53, 13.60, 7.28, 9.06, 11.18},
                {12.37, 13.34, 3.16, 12.21, 5.83, 4.47, 0.00, 4.00, 1.00, 13.00, 13.15, 13.60, 3.00, 5.10, 13.15},
                {13.89, 13.04, 7.07, 10.44, 9.49, 8.25, 4.00, 0.00, 5.00, 13.60, 13.15, 13.00, 1.00, 1.41, 14.32},
                {12.17, 13.60, 2.24, 12.81, 5.00, 3.61, 1.00, 5.00, 0.00, 13.04, 13.34, 13.93, 4.00, 6.08, 13.04},
                {3.16, 3.00, 12.37, 7.62, 11.18, 11.70, 13.00, 13.60, 13.04, 0.00, 2.00, 4.00, 13.34, 13.00, 2.00},
                {5.10, 1.00, 13.00, 5.83, 12.21, 12.53, 13.15, 13.15, 13.34, 2.00, 0.00, 2.00, 13.04, 12.37, 4.00},
                {7.07, 1.00, 13.89, 4.24, 13.45, 13.60, 13.60, 13.00, 13.93, 4.00, 2.00, 0.00, 13.04, 12.04, 6.00},
                {13.42, 13.00, 6.08, 10.77, 8.54, 7.28, 3.00, 1.00, 4.00, 13.34, 13.04, 13.04, 0.00, 2.24, 13.93},
                {13.60, 12.17, 8.00, 9.22, 10.20, 9.06, 5.10, 1.41, 6.08, 13.00, 12.37, 12.04, 2.24, 0.00, 13.89},
                {1.41, 5.00, 12.04, 9.49, 10.44, 11.18, 13.15, 14.32, 13.04, 2.00, 4.00, 6.00, 13.93, 13.89, 0.00}
            };

            /*for (int i = 0; i < 5; i++) //заполнение матрицы расстояний
            {
                for (int j = 0; j < 5; j++)
                {
                    Matrix[i, j] = calcCityDistance(citiesList[i], citiesList[j]);
                }
            }*/
            for (int i = 0; i < 15; i++)
            {
                City city = new City();
                citiesList.Add(city);
            }
            nearestNeighborsMethod(citiesList, Matrix2);
        }
        static int returnRandomNumber(int Maxvalue)
        {
            int value;
            Random rnd = new Random();
            value = rnd.Next(0, Maxvalue);
            return value;
        }
        static void nearestNeighborsMethod(List<City> citieslist, double[,] Matrix)
        {
            var Path = new List<int>();
            double totalDistance = 0;
            Console.WriteLine("-----------------------");
            Console.WriteLine("Метод ближайшего соседа");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Матрица расстояний городов:");
            Console.WriteLine();
            for (int i = 0; i < citieslist.Count; i++)
            {
                Console.Write("{0,-7} ", i);
            }
            Console.Write("\n");
            for (int i = 0; i < citieslist.Count; i++)
            {
                Console.Write("{0,-7} ", "_");
            }
            Console.Write("\n");
            Console.WriteLine();
            for (int i = 0; i < citieslist.Count; i++)
            {
                for (int j = 0; j < citieslist.Count; j++)
                {
                    Console.Write("{0,-7} ", Matrix[i, j]);
                }
                Console.Write("{0,-7} ", "| " + i + " город");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            int Exit = 1;
            while (Exit == 1)
            {
                int selectedCity = returnRandomNumber(Maxvalue:15);
                citieslist[selectedCity].wasVisited = true;
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

                while (step < citieslist.Count)
                {
                    int nearestCity = -1;
                    double minDist = 999;
                    Console.WriteLine("Номер шага: " + step);
                    Console.WriteLine();
                    for (int i = selectedCity; i < selectedCity + 1; i++)
                    {
                        for (int j = 0; j < 15; j++)//просматриваем расстояния от выбранного до других
                        {
                            if (Matrix[i, j] < minDist && !citieslist[j].wasVisited)
                            {
                                minDist = Matrix[i, j];
                                nearestCity = j;
                            }
                        }
                    }
                    totalDistance += minDist;
                    citieslist[nearestCity].wasVisited = true;
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
                for (int i = 0; i < citieslist.Count; i++)
                {
                    citieslist[i].wasVisited = false; //сброс флагов
                }
                totalDistance = 0; //сброс дистанции
                Path.Clear();
                Console.WriteLine("Для повтора программы нажмите 1, для выхода нажмите 0: ");
                Exit = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
        static double calcCityDistance(City A, City B)
        {
            double xVal = Math.Pow(B.X - A.X, 2);
            double yVal = Math.Pow(B.Y - A.Y, 2);
            double dist = Math.Sqrt(xVal + yVal);
            return dist;
        }
    }
}
