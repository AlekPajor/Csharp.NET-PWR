using Backpack;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private BackpackClass backpack;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtbInstance.Clear();
                txtbResults.Clear();

                txtbNumberOfItems.BackColor = Color.White;
                txtbSeed.BackColor = Color.White;
                txtbCapacity.BackColor = Color.White;

                if (!int.TryParse(txtbNumberOfItems.Text, out int numberOfItems) || numberOfItems <= 0) 
                {
                    txtbNumberOfItems.BackColor = Color.IndianRed;
                    throw new Exception("Invalid number");
                }
                
                if (!int.TryParse(txtbCapacity.Text, out int capacity) || capacity <= 0) 
                {
                    txtbCapacity.BackColor = Color.IndianRed;
                    throw new Exception("Invalid number");
                }
                
                if (!int.TryParse(txtbSeed.Text, out int seed)) 
                {
                    txtbSeed.BackColor = Color.IndianRed;
                    throw new Exception("Invalid number");
                }

                backpack = new BackpackClass(numberOfItems, seed);
                Result result = backpack.Solve(capacity);

                txtbInstance.Text = backpack.ToString();
                txtbResults.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
