using ChuckNorrisJokes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GUI")]
namespace ChuckNorrisJokes
{
    internal class JokesAPI
    {
        private HttpClient httpClient;
        private Joke joke;
        public async Task<string> getJokeBycategory(string category)
        {
            httpClient = new HttpClient();
            String url = $"https://api.chucknorris.io/jokes/random?category={category}";
            string response = await httpClient.GetStringAsync(url);
            joke = JsonSerializer.Deserialize<Joke>(response);
            return joke.value;
        }

        public Joke getCurrentJokeProperties()
        {
            return joke;
        }
    }
}