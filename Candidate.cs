using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGA
{
    class Candidate
    {
        public int[] encoding { get; set; } //кодировка
        public int fitness { get; set; } //приспособленность
        public Candidate(int arrCount) 
        {
            encoding = new int[arrCount];
        }
    }
}
