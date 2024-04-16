using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokes
{
    internal class Joke
    {
        public string icon_url { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string value { get; set; }
        public string category { get; set; }

        public override string ToString()
        {
            return $"{value}";
        }
    }
}