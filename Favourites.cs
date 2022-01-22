using System;
using System.IO;
using System.Windows.Forms;

namespace Browser
{
    public partial class Favourites : Form
    {
        // Create instances of classes
        mainWindow main = new mainWindow();
        History history = new History();
        private string url;
        // Filename for favourites
        string filenameFave = Directory.GetCurrentDirectory() + "\\favourites.txt";

        // getter and setter methods for the chosen url
        public string getURL()
        {
            return url;
        }

        public void setURL(string _url)
        {
            url = _url;
        }


        public Favourites()
        {
            InitializeComponent();
        }

        // Load the favourites into the list view box 
        private void Favourites_Load(object sender, EventArgs e)
        {
            fave1.Clear();
            fave1.Columns.Add("Name", 120);
            fave1.Columns.Add("URL", 500);
            string[] favourites = getFavourites();


            if (favourites != null)
            {
                string[] temp = new string[2];

                for (int i = 0; i < favourites.Length; i += 2)
                {
                    temp[0] = favourites[i].ToString();
                    temp[1] = favourites[i + 1].ToString();
                    ListViewItem itm = new ListViewItem(temp);
                    fave1.Items.Add(itm);
                }
            }
       
        }

        // Get the list of favourites, return null if file not found
        public string[] getFavourites()
        {
            try
            {
                return (File.ReadAllLines(filenameFave));

            }
            catch { FileNotFoundException e; }
            {
                return null;
            }
        }



        // Load the page for the specified favourite chosen by the user
        private void loadFavourites_Click(object sender, EventArgs e)
        {
            try
            {
                // save chosen favourite to variable
                string url = fave1.SelectedItems[0].SubItems[1].Text;

                // Add to history
                history.saveURL(url);

                this.Close();

                // Call setter so main form can get URL
                setURL(url);

            }
            catch(ArgumentOutOfRangeException) {
                // If no favourite is chosen throw message box with error
                MessageBox.Show("Please select a favourite to access", "Favourites", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        // Navigate back to the main form
        private void back_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Close();
        }
    }
}
