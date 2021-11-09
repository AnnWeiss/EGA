using System;
using System.Collections.Generic;

namespace KnapsackProblem
{
    class Knapsack
    {
        public List<Item> capacity { get; private set; } //предметы
        private readonly int maxWeight; //весовое ограничение
        public int currentWeight { get; private set; } //текущий вес
        public int totalValue { get; private set; } //суммарная ценность рюкзака
        public Knapsack(int weight)
        {
            maxWeight = weight;
            capacity = new List<Item>();
        }
        public bool checkMaxWeight(int itemWeight)
        {
            if (currentWeight + itemWeight <= maxWeight)
            {
                return true;
            }
            return false;
        }
        public void foldItem(Item item)
        {
            if (currentWeight + item.weight > maxWeight)
            {
                throw new Exception("Переполнение!");
            }
            else
            {
                capacity.Add(item);
                item.wasTaken = true;
                currentWeight += item.weight;
                totalValue += item.price;
            }
        }
        public int getMaxWeight()
        {
            return maxWeight;
        }
    }
}
