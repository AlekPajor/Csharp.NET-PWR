using ChuckNorrisJokes;

namespace GUI
{
    public partial class Form1 : Form
    {
        private JokesAPI jokesAPI = new JokesAPI();
        private Joke currentJoke;
        public Form1()
        {
            InitializeComponent();
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {
            // TODO: local database handling code
        }

        private async void categoryBtn_Click(object sender, EventArgs e)
        {
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