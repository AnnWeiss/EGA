using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProj;

namespace EvolutionaryGeneticAlgorithm
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public List<City> citiesList = new List<City>();
        public List<Candidate> candidateList = new List<Candidate>();
        public List<Candidate> candidateList2 = new List<Candidate>();
        public int numberOfGeneration;
        public List<Candidate> alreadyAddedCandidates = new List<Candidate>();
        public double[,] Matrix2 = new double[15, 15]
        {
                {0.00, 12.53, 5.10, 11.70, 3.00, 13.04, 4.47, 1.00, 8.49, 7.62, 10.00, 13.15, 13.00, 13.60, 13.15 },
                {12.53, 0.00, 10.05, 10.00, 11.40, 7.28, 13.45, 13.04, 13.00, 8.06, 5.39, 8.25, 6.32, 2.83, 4.47 },
                {5.10, 10.05, 0.00, 13.45, 2.24, 13.42, 9.06, 6.08, 12.08, 2.83, 5.83, 13.89, 13.00, 12.04, 12.37 },
                {11.70, 10.00, 13.45, 0.00, 13.04, 3.61, 9.00, 11.40, 5.39, 13.60, 13.00, 2.83, 4.47, 8.25, 6.32 },
                {3.00, 11.40, 2.24, 13.04, 0.00, 13.60, 7.28, 4.00, 10.82, 5.00, 7.81, 13.93, 13.34, 13.04, 13.04 },
                {13.04, 7.28, 13.42, 3.61, 13.60, 0.00, 11.40, 13.00, 8.60, 12.81, 11.40, 1.00, 1.00, 5.00, 3.00 },
                {4.47, 13.45, 9.06, 9.00, 7.28, 11.40, 0.00, 3.61, 4.47, 11.05, 12.65, 11.18, 11.70, 13.60, 12.53 },
                {1.00, 13.04, 6.08, 11.40, 4.00, 13.00, 3.61, 0.00, 7.81, 8.54, 10.82, 13.04, 13.04, 13.93, 13.34 },
                {8.49, 13.00, 12.08, 5.39, 10.82, 8.60, 4.47, 7.81, 0.00, 13.34, 14.00, 8.06, 9.22, 12.21, 10.63 },
                {7.62, 8.06, 2.83, 13.60, 5.00, 12.81, 11.05, 8.54, 13.34, 0.00, 3.16, 13.45, 12.21, 10.44, 11.18 },
                {10.00, 5.39, 5.83, 13.00, 7.81, 11.40, 12.65, 10.82, 14.00, 3.16, 0.00, 12.21, 10.63, 8.06, 9.22 },
                {13.15, 8.25, 13.89, 2.83, 13.93, 1.00, 11.18, 13.04, 8.06, 13.45, 12.21, 0.00, 2.00, 6.00, 4.00 },
                {13.00, 6.32, 13.00, 4.47, 13.34, 1.00, 11.70, 13.04, 9.22, 12.21, 10.63, 2.00, 0.00, 4.00, 2.00 },
                {13.60, 2.83, 12.04, 8.25, 13.04, 5.00, 13.60, 13.93, 12.21, 10.44, 8.06, 6.00, 4.00, 0.00, 2.00 },
                {13.15, 4.47, 12.37, 6.32, 13.04, 3.00, 12.53, 13.34, 10.63, 11.18, 9.22, 4.00, 2.00, 2.00, 0.00}
        };
        public Form1()
        {
            InitializeComponent();
        }
        public void codingSolutions()//кодирование решений
        {
            for (int i = 0; i < 15; i++)
            {
                City city = new City();
                citiesList.Add(city);
            }
            for (int i = 0; i < 15; i++)
            {
                Candidate objCand = new Candidate();
                if(nearestNeighborRadioButton.Checked)
                {
                    objCand.encoding2 = MyLibrary.nearestNeighborsMethod(citiesList, Matrix2, rnd);
                }
                if (nearestCityRadioButton.Checked)
                {
                    objCand.encoding2 = MyLibrary.nearestCityMethod(citiesList, Matrix2, rnd);
                }
                candidateList.Add(objCand);
            }
            setFitness(ref candidateList);
        }
        public void setFitness(ref List<Candidate> candidateList) //оценивание
        {
            for (int i = 0; i < candidateList.Count; i++)
            {
                candidateList[i].setDistance(Matrix2);
            }
            for (int i = 0; i < candidateList.Count - 1; i++)//сортировка пузырьком
            {
                for (int j = 0; j < candidateList.Count - i - 1; j++)
                {
                    if (candidateList[j].totalDistance < candidateList[j + 1].totalDistance)
                    {
                        Candidate temp = candidateList[j];
                        candidateList[j] = candidateList[j + 1];
                        candidateList[j + 1] = temp;
                    }
                }
            }
            //задаем приспособленность на основе числа итогового пути
            candidateList[0].fitness = 1;
            int totalFitness = 1;
            for (int i = 1; i < candidateList.Count; i++)
            {
                if (candidateList[i].totalDistance < candidateList[i - 1].totalDistance)
                {
                    totalFitness++;
                    candidateList[i].fitness = totalFitness;
                }
                else
                {
                    candidateList[i].fitness = totalFitness;
                }
            }
        }
        public void crossover()
        {
            for (int i = 0; i < 15; i++)
            {
                Candidate objCand = new Candidate();//создаем пустых особей
                for (int j = 0; j < 15; j++)
                {
                    objCand.encoding2.Add(-1);
                }
                candidateList2.Add(objCand);
            }
            if (OXradioButton.Checked)
            {
                for (int i = 0; i < 15; i++)
                {
                    candidateList2[i] = MyLibrary.crossOX(candidateList2[i],candidateList, rnd);
                }
            }
            if (PMXradioButton.Checked)
            {
                for (int i = 0; i < 15; i++)
                {
                    candidateList2[i] = MyLibrary.crossPMX(candidateList2[i], candidateList, rnd);
                }
            }
        }
        public void mutation()
        {
            double prob; //если вероятность много меньше единицы, то мутируем
            if (genRadioButton.Checked)
            {
                for (int i = 0; i < 15; i++)
                {
                    prob = rnd.NextDouble();
                    if (prob < 0.2)
                    {
                        candidateList2[i] = MyLibrary.genMutation(candidateList2[i], rnd);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (macroRadioButton.Checked)
            {
                for (int i = 0; i < 15; i++)
                {
                    prob = rnd.NextDouble();
                    if (prob < 0.2)
                    {
                        candidateList2[i] = MyLibrary.macroMutation(candidateList2[i], rnd);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (chromRadioButton.Checked)
            {
                for (int i = 0; i < 15; i++)
                {
                    prob = rnd.NextDouble();
                    if (prob < 0.2)
                    {
                        candidateList2[i].encoding2 = MyLibrary.nearestNeighborsMethod(citiesList, Matrix2, rnd);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            setFitness(ref candidateList2);//присвоение мутированным кодировкам приспособленности
        }
        public void selection()
        {
            candidateList.Clear();
            if (betaRadioButton.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    candidateList.Add(MyLibrary.betaTournament(candidateList2, rnd, alreadyAddedCandidates));
                }
                candidateList2.Clear();
            }
            if (proportionalRadioButton.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    candidateList.Add(MyLibrary.proportionalTournament(candidateList2, rnd));
                }
                candidateList2.Clear();
            }
        }
        public void printPopulationToListBox(List<Candidate> candList)
        {
            listBox1.Items.Add("Номер поколения:" + numberOfGeneration);
            for (int i = 0; i < candList.Count; i++)
            {
                listBox1.Items.Add(string.Join(" ", candList[i].encoding2)+"\t"+ string.Join(" ", candList[i].fitness));
            }
            int idx = 0;
            for (int i = 1; i < candList.Count; i++)
            {
                if (candList[i].fitness > candList[idx].fitness)
                {
                    idx = i;
                }
            }
            listBox1.Items.Add("Наилучшая особь:");
            listBox1.Items.Add(string.Join(" ", candList[idx].encoding2) + "\t" + string.Join(" ", candList[idx].fitness));
            listBox1.Items.Add("\n");
        }
        private void nearestNeighborRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nearestCityRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OXradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RMXradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            citiesList.Clear();
            candidateList.Clear();
            candidateList2.Clear();
            listBox1.Items.Clear();
            numberOfGeneration = 0;
            codingSolutions();
            while (numberOfGeneration < Convert.ToInt32(textBox1.Text))
            {
                numberOfGeneration++;
                crossover();
                mutation();
                selection();
                printPopulationToListBox(candidateList);
            }
        }

        private void genRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void macroRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chromRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
