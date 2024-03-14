namespace Backpack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackpackClass backpack = new BackpackClass(10, 10);
            Console.WriteLine(backpack.ToString());
            Console.WriteLine(backpack.Solve(50).ToString());
        }
    }
}