using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]
[assembly: InternalsVisibleTo("WinFormsApp1"), InternalsVisibleTo("GUI")]
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
            if (capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative.");
            }

            int c = capacity;
            List<Item> FinalItems = new List<Item>();
            Items = Items.OrderByDescending(p => p.ValueToWeightRatio).ToList();

            foreach (Item item in Items)
            {
                if(c - item.Weight >= 0)
                {
                    FinalItems.Add(item);
                    c -= item.Weight;
                }
            }

            return new Result(FinalItems);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Number of available Items = {NumberOfItems}");

            foreach (Item item in Items)
            {
                sb.AppendLine($"Item: {item.Number}, Weight: {item.Weight}, Value: {item.Value}\n");
            }
            return sb.ToString();
        }
    }
}
