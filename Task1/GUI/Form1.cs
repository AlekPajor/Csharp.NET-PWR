using ChuckNorrisJokes;
using System.Text;

namespace GUI
{
    public partial class Form1 : Form
    {
        JokesAPI jokesAPI;
        Joke currentJoke;
        Favourites favourites;

        public Form1()
        {
            InitializeComponent();
            jokesAPI = new JokesAPI();
            favourites = new Favourites();
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {
            var toAdd = JokeEntity.MapToJokeEntity(currentJoke);
            try { 
                var existingJoke = favourites.MyFavorites.FirstOrDefault(j => j.JokeId == toAdd.JokeId);
                if (existingJoke == null)
                {
                    likeBtn.BackColor = Color.LightGreen;
                    favourites.MyFavorites.Add(toAdd);
                    favourites.SaveChanges();
                }
                else
                {
                    MessageBox.Show("This joke is already in your favorites.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void randomFavoritesBtn_Click(object sender, EventArgs e)
        {
            if (favourites.MyFavorites.Any())
            {
                Random random = new Random();
                int randomIndex = random.Next(0, favourites.MyFavorites.Count());
                JokeEntity randomFavoriteJoke = favourites.MyFavorites.Skip(randomIndex).FirstOrDefault();

                if (randomFavoriteJoke != null)
                {
                    likeBtn.BackColor = Color.White;
                    textBox.Text = randomFavoriteJoke.Value;
                }
                else
                {
                    MessageBox.Show("Failed to retrieve a random favorite joke.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You haven't added any jokes to your favorites yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void categoryBtn_Click(object sender, EventArgs e)
        {
            likeBtn.BackColor = Color.White;
            var clickedCategory = (sender as Button).Text.ToLower();
            try { 
                string jokeText = await jokesAPI.getJokeBycategory(clickedCategory);
                textBox.Text = jokeText.ToString();
                currentJoke = jokesAPI.getCurrentJokeProperties();
                currentJoke.category = clickedCategory;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getByIdBtn_Click(object sender, EventArgs e)
        {
            string inputID = inputTextBox.Text;
            var existingJoke = favourites.MyFavorites.FirstOrDefault(j => j.JokeId == inputID);
            try
            {
                if (existingJoke == null)
                {
                    string jokeText = await jokesAPI.getJokeById(inputID);
                    textBox.Text = jokeText.ToString();
                    currentJoke = jokesAPI.getCurrentJokeProperties();
                    currentJoke.category = "Unknown";
                }
                else
                {
                    textBox.Text = existingJoke.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var jokeCounts = favourites.MyFavorites
                    .GroupBy(j => j.Category)
                    .Select(g => new { Category = g.Key, Count = g.Count() })
                    .ToList();

                StringBuilder message = new StringBuilder();
                foreach (var jokeCount in jokeCounts)
                {
                    message.AppendLine($"{jokeCount.Category}: {jokeCount.Count}");
                }

                MessageBox.Show(message.ToString(), "Joke Counts by Category", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}