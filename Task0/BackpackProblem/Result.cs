using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]
namespace Backpack
{
    internal class Result
    {
        public List<int> ItemsNumbers = [];
        public int SumOfValue { get; }
        public int SumOfWeight { get; }

        public Result(List<Item> items) 
        {
            foreach (Item item in items)
            {
                ItemsNumbers.Add(item.Number);
                SumOfValue += item.Value;
                SumOfWeight += item.Weight;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Items Numbers: " + string.Join(", ", ItemsNumbers));
            sb.AppendLine("Sum of Value: " + SumOfValue);
            sb.AppendLine("Sum of Weight: " + SumOfWeight);

            return sb.ToString();
        }
    }
}
