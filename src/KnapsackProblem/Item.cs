

namespace KnapsackProblem
{
    class Item
    {
        public int price;
        public int weight;
        public bool wasTaken;
        public Item(int price, int weight)
        {
            this.price = price;
            this.weight = weight;
        }
    }
}
