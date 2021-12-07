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
        public double[,] Matrix2 = new double[15, 15]
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
        public Form1()
        {
            InitializeComponent();
        }
        public void CodingSolutions()//кодирование решений
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
                objCand.fitness = rnd.Next(1,16); //задается случайная приспособленность
                candidateList.Add(objCand);
            }
        }
        public void Crossover()
        {
            for (int i = 0; i < 15; i++)
            {
                Candidate objCand = new Candidate();//создаем пустых особей
                candidateList2.Add(objCand);
            }
            if (OXradioButton.Checked)
            {
                for (int i = 0; i < 15; i++)
                {
                    candidateList2[i] = MyLibrary.OX(candidateList2[i],candidateList, rnd);
                }
            }
            if (PMXradioButton.Checked)
            {

            }
        }
        public void printPopulationToListBox(List<Candidate> candList)
        {
            listBox1.Items.Add("Кодировки и приспособленность:");
            for (int i = 0; i < candList.Count; i++)
            {
                listBox1.Items.Add(string.Join(" ", candList[i].encoding2)+"\t"+ string.Join(" ", candList[i].fitness));
            }
        }
        private void nearestNeighborRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nearestCityRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void resetAll()
        {
            citiesList.Clear();
            candidateList.Clear();
            candidateList2.Clear();
            nearestCityRadioButton.Checked = false;
            nearestNeighborRadioButton.Checked = false;
            OXradioButton.Checked = false;
            listBox1.Items.Clear();
        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void OXradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RMXradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            CodingSolutions();
            printPopulationToListBox(candidateList);
            Crossover();
            printPopulationToListBox(candidateList2);
        }
    }
}
