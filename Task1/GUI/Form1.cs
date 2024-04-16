using ChuckNorrisJokes;

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
    }
}