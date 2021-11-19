using System.Collections.Generic;

namespace EGA
{
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
}
