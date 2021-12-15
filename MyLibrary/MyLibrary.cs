using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    public class City
    {
        public bool wasVisited { get; set; }
        public City()
        {

        }
    }
    public class Candidate
    {
        public List<int> encoding2; //кодировка для задачи ЗК
        public double totalDistance;
        public int fitness; //приспособленность
        public Candidate()
        {
            encoding2 = new List<int>();
        }
        public void setDistance(double[,] Matrix)
        {
            if (encoding2.Count < 2)
            {
                throw new Exception("Ошибка алгоритма");
            }
            for (int i = 1; i < encoding2.Count; i++)
            {
                double dist = Matrix[encoding2[i], encoding2[i-1]];
                totalDistance += dist;
            }
        }
    }
    public static class MyLibrary
    {
        public static Candidate proportionalTournament(List<Candidate> candidatesList, Random rnd, List<Candidate> alreadyAddedCandidates)
        {
            Candidate bestCandidate = new Candidate();
            return bestCandidate;
        }
        public static Candidate betaTournament(List<Candidate> candidatesList, Random rnd, List<Candidate> alreadyAddedCandidates)
        {
            for (int i = 0; i < 3; i++)
            {
                int d = rnd.Next(1, candidatesList.Count);
                if (!alreadyAddedCandidates.Contains(candidatesList[d]))
                {
                    alreadyAddedCandidates.Add(candidatesList[d]);
                }
                else
                {
                    while (alreadyAddedCandidates.Contains(candidatesList[d]))
                    {
                        d = rnd.Next(1, candidatesList.Count);
                    }
                    alreadyAddedCandidates.Add(candidatesList[d]);
                }
            }
            //выбор лучшего из трех
            Candidate bestCandidate = new Candidate();
            bestCandidate = alreadyAddedCandidates[0];
            for (int i = 1; i < alreadyAddedCandidates.Count; i++)
            {
                if (alreadyAddedCandidates[i].fitness > bestCandidate.fitness)
                {
                    bestCandidate = alreadyAddedCandidates[i];
                }
            }
            candidatesList.Remove(bestCandidate);
            alreadyAddedCandidates.Clear();
            return bestCandidate;
        }
        public static Candidate macroMutation(Candidate candidate, Random rnd)
        {
            int firstidx = rnd.Next(0, 13);
            int secondidx = rnd.Next(firstidx + 2, 15);
            candidate.encoding2[firstidx] = candidate.encoding2[firstidx] + candidate.encoding2[secondidx];
            candidate.encoding2[secondidx] = candidate.encoding2[firstidx] - candidate.encoding2[secondidx];
            candidate.encoding2[firstidx] = candidate.encoding2[firstidx] - candidate.encoding2[secondidx];
            return candidate;
        }
        public static Candidate genMutation(Candidate candidate, Random rnd)
        {
            int firstidx = rnd.Next(0, 14);
            int secondidx = firstidx + 1;
            candidate.encoding2[firstidx] = candidate.encoding2[firstidx] + candidate.encoding2[secondidx];
            candidate.encoding2[secondidx] = candidate.encoding2[firstidx] - candidate.encoding2[secondidx];
            candidate.encoding2[firstidx] = candidate.encoding2[firstidx] - candidate.encoding2[secondidx];
            return candidate;
        }
        public static Candidate crossPMX(Candidate child, List<Candidate> candidatesList, Random rnd)
        {
            int firstParent = rnd.Next(0, candidatesList.Count);
            int secondParent = rnd.Next(0, candidatesList.Count);
            int firstSection = rnd.Next(1, candidatesList.Count-2);
            int secondSection = rnd.Next(firstSection, candidatesList.Count-1);
            List<int> firstblock = new List<int>();//таблица отображений
            List<int> secondblock = new List<int>();//таблица отображений
            List<int> fillerblock = new List<int>();
            //копирование секции из 1 родителя
            for (int i = firstSection; i <= secondSection; i++)
            {
                child.encoding2[i] = candidatesList[firstParent].encoding2[i];
                firstblock.Add(candidatesList[firstParent].encoding2[i]);
                secondblock.Add(candidatesList[secondParent].encoding2[i]);
            }
            for (int i = 0; i < secondblock.Count; i++)
            {
                if (firstblock.Contains(secondblock[i]))
                {
                    while (firstblock.Contains(secondblock[i]))
                    {
                        int numberFromFirst = secondblock[i];
                        var indexOfElementFromFirstblock = firstblock.IndexOf(numberFromFirst);
                        int numberFromSecond = secondblock[indexOfElementFromFirstblock];
                        secondblock[i] = numberFromSecond;
                        if(numberFromFirst == numberFromSecond)
                        {
                            break;
                        }
                    }
                }
            }
            //заполнение fillerblock
            for (int i = secondSection + 1; i < candidatesList[secondParent].encoding2.Count; i++)
            {
                if (!firstblock.Contains(candidatesList[secondParent].encoding2[i]))//не входит в блок
                {
                    if (!child.encoding2.Contains(candidatesList[secondParent].encoding2[i]))
                    {
                        fillerblock.Add(candidatesList[secondParent].encoding2[i]);
                    }
                }
                else//входит в блок
                {
                    int index = firstblock.IndexOf(candidatesList[secondParent].encoding2[i]);
                    if (!child.encoding2.Contains(secondblock[index]))
                    {
                        fillerblock.Add(secondblock[index]);
                    }
                }
            }
            for (int i = 0; i < firstSection; i++)
            {
                if (!firstblock.Contains(candidatesList[secondParent].encoding2[i]))//не входит в блок
                {
                    if (!child.encoding2.Contains(candidatesList[secondParent].encoding2[i]))
                    {
                        fillerblock.Add(candidatesList[secondParent].encoding2[i]);
                    }
                }
                else//входит в блок
                {
                    int index = firstblock.IndexOf(candidatesList[secondParent].encoding2[i]);
                    if (!child.encoding2.Contains(secondblock[index]))
                    {
                        fillerblock.Add(secondblock[index]);
                    }
                }
            }
            for (int i = firstSection; i <= secondSection; i++)
            {
                if (!firstblock.Contains(candidatesList[secondParent].encoding2[i]))//не входит в блок
                {
                    if (!child.encoding2.Contains(candidatesList[secondParent].encoding2[i]))
                    {
                        fillerblock.Add(candidatesList[secondParent].encoding2[i]);
                    }
                }
                else//входит в блок
                {
                    int index = firstblock.IndexOf(candidatesList[secondParent].encoding2[i]);
                    if (!child.encoding2.Contains(secondblock[index]))
                    {
                        fillerblock.Add(secondblock[index]);
                    }
                }
            }
            //заполнение потомка из fillerblock
            for (int i = secondSection + 1; i < child.encoding2.Count; i++)
            {
                child.encoding2[i] = fillerblock[0];
                fillerblock.RemoveAt(0);
            }
            for (int i = 0; i < firstSection; i++)
            {
                child.encoding2[i] = fillerblock[0];
                fillerblock.RemoveAt(0);
            }
            return child;
        }
        public static Candidate crossOX(Candidate child, List<Candidate> candidatesList, Random rnd)
        {
            int firstParent = rnd.Next(0, candidatesList.Count);
            int secondParent = rnd.Next(0, candidatesList.Count);
            int firstSection = rnd.Next(1, candidatesList.Count-2);
            int secondSection = rnd.Next(firstSection, candidatesList.Count-1);
            List<int> fillerblock = new List<int>();
            //копирование секции из 1 родителя
            for (int i = firstSection; i <= secondSection; i++)
            {
                child.encoding2[i] = candidatesList[firstParent].encoding2[i];
            }
            //заполнение fillerblock
            for (int i = secondSection + 1; i < candidatesList[secondParent].encoding2.Count; i++)
            {
                if (!child.encoding2.Contains(candidatesList[secondParent].encoding2[i]))
                {
                    fillerblock.Add(candidatesList[secondParent].encoding2[i]);
                }
            }
            for (int i = 0; i < firstSection; i++)
            {
                if (!child.encoding2.Contains(candidatesList[secondParent].encoding2[i]))
                {
                    fillerblock.Add(candidatesList[secondParent].encoding2[i]);
                }
            }
            for (int i = firstSection; i <= secondSection; i++)
            {
                if (!child.encoding2.Contains(candidatesList[secondParent].encoding2[i]))
                {
                    fillerblock.Add(candidatesList[secondParent].encoding2[i]);
                }
            }
            //заполнение потомка из fillerblock
            for (int i = secondSection + 1; i < child.encoding2.Count; i++)
            {
                child.encoding2[i] = fillerblock[0];
                fillerblock.RemoveAt(0);
            }
            for (int i = 0; i < firstSection; i++)
            {
                child.encoding2[i] = fillerblock[0];
                fillerblock.RemoveAt(0);
            }
            return child;
        }
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
