using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backpack
{
    internal class BackpackClass
    {
        public int NumberOfItems { get; private set; }
        public List<Item> Items { get; private set; }
        private int seed;

        public BackpackClass(int n, int setSeed)
        {
            seed = setSeed;
            NumberOfItems = n;
            Items = [];
            Random rnd = new Random(seed);

            for (int i = 0; i < n; i++)
            {
                Item item = new Item(rnd.Next(0, 11), rnd.Next(0, 11), i);
                Items.Add(item);
            }
        }

        public Result Solve(int capacity)
        {
            int c = capacity;
            List<Item> FinalItems = new List<Item>();
            Items = Items.OrderByDescending(p => p.ValueToWeightRatio).ToList();

            foreach (Item item in Items)
            {
                if(c - item.Weight > 0)
                {
                    FinalItems.Add(item);
                    c -= item.Weight;
                }
            }

            return new Result(FinalItems);
        }

        public override string ToString()
        {
            string result = $"Number of available Items = {NumberOfItems}\n";
            foreach (Item item in Items)
            {
                result += $"Item: {item.Number}, Weight: {item.Weight}, Value: {item.Value}\n";
            }
            return result;
        }
    }
}
