

namespace EGA
{
    public class Candidate
    {
        public int[] encoding; //кодировка
        public int fitness; //приспособленность
        public Candidate(int arrCount) 
        {
            encoding = new int[arrCount];
        }
    }
}
