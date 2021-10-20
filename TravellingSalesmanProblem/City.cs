using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanProblem
{
    class City
    {
        public bool wasVisited { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public City(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
