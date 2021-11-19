using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellingSalesmanProblem;

namespace MyProj
{
    public class City
    {
        public bool wasVisited { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public City(int x, int y)
        {
            X = x;
            Y = y;
        }
        public City()
        {

        }
    }
    public class Candidate
    {
        public int[] encoding; //кодировка для М-М-К
        public List<int> encoding2; //кодировка для задачи ЗК
        public int fitness; //приспособленность
        public Candidate(int arrCount)
        {
            encoding = new int[arrCount];
        }
        public Candidate(List<int> encode)
        {
            encoding2 = encode;
        }
        public Candidate()
        {

        }
    }
    public static class MyLibrary
    {
        public static List<int> nearestCityMethod(List<City> citieslist, double[,] Matrix, Random rnd)
        {
            var Path = new List<int>();//итоговая кодировка
            var Candidates = new List<int>();//кандидаты на вставку

            int selectedCity = rnd.Next(citieslist.Count);//первый город выбирается случайно
            citieslist[selectedCity].wasVisited = true;
            Path.Add(selectedCity);
            while (Path.Count < 15)
            {
                int nearestCity = -1;
                double minDist = 999;

                if (Path.Count == citieslist.Count - 1)
                {
                    for (int i = 0; i < citieslist.Count; i++)
                    {
                        if (!citieslist[i].wasVisited)
                        {
                            nearestCity = i;
                        }
                    }
                    //пройдемся по path и вставим nearestCity после кратчайшего города
                    int index = -1;
                    for (int i = 0; i < Path.Count; i++)
                    {
                        if (Matrix[nearestCity, Path[i]] < minDist && Matrix[nearestCity, Path[i]] != 0)
                        {
                            minDist = Matrix[nearestCity, Path[i]];
                            index = i;
                        }
                    }
                    Path.Insert(index + 1, nearestCity);
                }
                else
                {
                    for (int i = 0; i < citieslist.Count; i++)
                    {
                        for (int j = 0; j < citieslist.Count; j++)//просматриваем расстояния от выбранного до других
                        {
                            if (Matrix[i, j] < minDist && !citieslist[j].wasVisited && Matrix[i, j] != 0)
                            {
                                minDist = Matrix[i, j];
                                nearestCity = j;
                            }
                        }
                        Candidates.Add(nearestCity);//добавим ближайшего кандидата
                        minDist = 999;//сброс значений
                        nearestCity = -1;
                    }
                    //выбор кандидата, имеющего наименьш.расст до предшествующего из path
                    for (int i = Path.Count - 1; i < Path.Count; i++)
                    {
                        for (int j = 0; j < Candidates.Count; j++)
                        {
                            if (Matrix[Path[i], Candidates[j]] < minDist && Matrix[Path[i], Candidates[j]] != 0)
                            {
                                minDist = Matrix[Path[i], Candidates[j]];
                                nearestCity = Candidates[j];
                            }

                        }
                        minDist = 999;//сброс значений
                    }
                    //пройдемся по path и вставим nearestCity после кратчайшего города
                    int index = -1;
                    for (int i = 0; i < Path.Count; i++)
                    {
                        if (Matrix[nearestCity, Path[i]] < minDist && Matrix[nearestCity, Path[i]] != 0)
                        {
                            minDist = Matrix[nearestCity, Path[i]];
                            index = i;
                        }
                    }
                    Path.Insert(index + 1, nearestCity);
                    citieslist[nearestCity].wasVisited = true;
                    Candidates.Clear();
                }
            }

            for (int i = 0; i < citieslist.Count; i++)
            {
                citieslist[i].wasVisited = false; //сброс флагов
            }
            return Path;
        }
        public static List<int> nearestNeighborsMethod(List<City> citieslist, double[,] Matrix, Random rnd)
        {
            var Path = new List<int>();
            int selectedCity = rnd.Next(citieslist.Count);
            citieslist[selectedCity].wasVisited = true;
            int step = 0;
            Path.Add(selectedCity);
            step++;

            while (step < citieslist.Count)
            {
                int nearestCity = -1;
                double minDist = 999;
                for (int i = selectedCity; i < selectedCity + 1; i++)
                {
                    for (int j = 0; j < citieslist.Count; j++)//просматриваем расстояния от выбранного до других
                    {
                        if (Matrix[i, j] < minDist && !citieslist[j].wasVisited)
                        {
                            minDist = Matrix[i, j];
                            nearestCity = j;
                        }
                    }
                }
                citieslist[nearestCity].wasVisited = true;
                Path.Add(nearestCity);
                selectedCity = nearestCity;
                step++;
            }
            for (int i = 0; i < citieslist.Count; i++)
            {
                citieslist[i].wasVisited = false; //сброс флагов
            }
            return Path;
        }
    }
}
