using Backpack;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAtLeastOneGoodItem()
        {
            // testing if result is correct for at least one item that meets requirements

            BackpackClass backpack = new BackpackClass(5, 123);
            backpack.Items.Add(new Item(10, 10, 987));

            Result result = backpack.Solve(10);

            Assert.IsTrue(result.ItemsNumbers.Any());

        }

        [TestMethod] public void TestAllFaultyItems()
        {
            // testing if result is correct for backpack that cannot contain any given items 

            BackpackClass backpack = new BackpackClass(5, 123);
            backpack.Items.Clear();

            backpack.Items.Add(new Item(10, 1, 0));
            backpack.Items.Add(new Item(10, 2, 1));
            backpack.Items.Add(new Item(10, 3, 2));

            Result result = backpack.Solve(9);

            Assert.IsFalse(result.ItemsNumbers.Any());
            Assert.AreEqual(0, result.SumOfValue);
            Assert.AreEqual(0, result.SumOfWeight);
        }

        [TestMethod]
        public void TestOrderOfItems()
        {
            // testing if different order of items give different result (it shouldn't with the Solve() sorting)

            BackpackClass backpack = new BackpackClass(20, 123);

            Result result1 = backpack.Solve(10);

            backpack.Items.OrderBy(a => Guid.NewGuid()).ToList();
            Result result2 = backpack.Solve(10);

            Assert.AreEqual(result1.SumOfValue, result2.SumOfValue);
            Assert.AreEqual(result1.SumOfWeight, result2.SumOfWeight);
            Assert.AreEqual(result1.ItemsNumbers.Count, result2.ItemsNumbers.Count);
        }

        [TestMethod]
        public void TestCertainInstance()
        {
            // testing if certain instance is being calculated properly

            BackpackClass backpack = new BackpackClass(10, 123);
            Result result = backpack.Solve(30);

            int SumOfWeightCounter = 0;
            int SumOfValueCounter = 0;
            foreach (var number in result.ItemsNumbers)
            {
                Item item = backpack.Items.Find(i => i.Number == number);
                SumOfValueCounter += item.Value;
                SumOfWeightCounter += item.Weight;
            }

            Assert.AreEqual(SumOfValueCounter, result.SumOfValue);
            Assert.AreEqual(SumOfWeightCounter, result.SumOfWeight);
        }

        [TestMethod]
        public void TestZeroCapacity()
        {
            // testing if backpack with zero capcity contains items with weight zero or is empty

            BackpackClass backpack = new BackpackClass(10, 123);
            Result result = backpack.Solve(0);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.SumOfWeight);

            if(!result.ItemsNumbers.Any())
            {
                Assert.AreEqual(0, result.ItemsNumbers.Count);
            }
            else
            {
                foreach (var number in result.ItemsNumbers)
                {
                    Item item = backpack.Items.Find(i => i.Number == number);
                    Assert.IsNotNull(item);
                    Assert.AreEqual(0, item.Weight);
                }
            }
        }

        [TestMethod]
        public void TestRandomSeed()
        {
            // testing if different seeds give different outcomes

            BackpackClass backpack1 = new BackpackClass(5, 123);
            BackpackClass backpack2 = new BackpackClass(5, 456);

            Result result1 = backpack1.Solve(10);
            Result result2 = backpack2.Solve(10);

            Assert.IsNotNull(result1);
            Assert.IsNotNull(result2);
            CollectionAssert.AreNotEqual(result1.ItemsNumbers, result2.ItemsNumbers);
        }

        [TestMethod]
        public void TestMoreCapacityThanTotalWeight()
        {
            // testing if backpack with capacity exceeding total weight of items contains them all

            BackpackClass backpack = new BackpackClass(10, 123);
            int totalWeight = backpack.Items.Sum(item => item.Weight);

            int capacity = totalWeight + 1;
            Result result = backpack.Solve(capacity);

            Assert.AreEqual(backpack.NumberOfItems, result.ItemsNumbers.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNegativeCapacity()
        {
            // testing if negative capacity throws an exception

            BackpackClass backpack = new BackpackClass(5, 123);
            backpack.Solve(-1);
        }

        [TestMethod]
        public void TestLargeCapacity()
        {
            // testing if large capacity doesn't break the code

            BackpackClass backpack = new BackpackClass(10, 456);
            int largeCapacity = 1000;

            Result result = backpack.Solve(largeCapacity);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.ItemsNumbers.Any());
        }
    }
}