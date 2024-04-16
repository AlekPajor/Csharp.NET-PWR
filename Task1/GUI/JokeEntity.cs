using ChuckNorrisJokes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class JokeEntity
    {
        public int Id { get; set; }
        public required string Value { get; set; }
        public required string Category { get; set; }
        public required string JokeId { get; set; }

        internal static JokeEntity MapToJokeEntity(Joke joke)
        {
            if (joke == null)
                return null;

            return new JokeEntity
            {
                Value = joke.value,
                Category = joke.category,
                JokeId = joke.id
            };
        }
    }
}
