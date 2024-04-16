namespace ChuckNorrisJokes
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            JokesAPI jokesAPI = new JokesAPI();
            string joke = await jokesAPI.getJokeBycategory("animal");
            Console.WriteLine(joke);
        }
    }
}
