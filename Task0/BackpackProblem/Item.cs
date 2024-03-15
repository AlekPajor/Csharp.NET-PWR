using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTests")]
namespace Backpack
{
    public struct Item
    {
        public int Weight;
        public int Value;
        public int Number;
        public double ValueToWeightRatio => (double)Value / Weight;

        public Item(int weight, int value, int number)
        {
            Weight = weight;
            Value = value;
            Number = number;
        }
    }
}
