using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Browser
{
    public partial class Settings : Form
    {
        // Declare filename variables and instances of classes
        string filenameHomepage = Directory.GetCurrentDirectory() + "\\homepage.txt";
        string filenameFave = Directory.GetCurrentDirectory() + "\\favourites.txt";
        string filenameHistory = Directory.GetCurrentDirectory() + "\\history.txt";
        History history = new History();
        Favourites favourite = new Favourites();

        public Settings()
        {
            InitializeComponent();
        }

        // Display the homepage, favourites and history in their relevant places upon form load
        private void Settings_Load(object sender, EventArgs e)
        {
            string homepage = File.ReadAllText(filenameHomepage);

            homepageURL.Text = homepage;

            displayFavourites();
            displayHistory();
        }

        // Read history from file and display 
        public void displayHistory()
        {
            string[] historyURLs = history.getHistory();

            historybox.Items.Clear();

            for (int i = 0; i < historyURLs.Length; i++)
            {
                historybox.Items.Add(historyURLs[i]);
            }
        }

        // Read favourites from file and display 
        private void displayFavourites()
        {
            string[] favourites = favourite.getFavourites();

            if (favourites != null)
            {
                faveNames1.Items.Clear();
                faveNames2.Items.Clear();
                for (int i = 0; i < favourites.Length; i += 2)
                {
                    faveNames1.Items.Add(favourites[i]);
                    faveNames2.Items.Add(favourites[i]);
                }
            } 

        }

        // Close this form and navigate back to the main form
        private void back_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Close();
        }

        // change homepage from user input, display error message if no value is entered
        private void setHomepage_Click_1(object sender, EventArgs e)
        {
            string homepage = homepageURL.Text;

            if (!string.IsNullOrEmpty(homepage))
            {
                File.WriteAllText(filenameHomepage, homepage);
                MessageBox.Show("Homepage successfully saved", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter in a homepage", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Check if a favourite of the name passed in already exists
        private bool checkFavourite(String name)
        {
            int i = 0;
            bool exists = false;

            string[] favourites = favourite.getFavourites();
            if (favourites == null)
            {
                return false;
            }

            do
            {
                if (favourites[i].Equals(name))
                {
                    exists = true;
                    break;
                }

                i += 2;
            } while (i < favourites.Length);

            return exists;
        }

        // Add a new favourite to the txt file, update the display once complete
        private void addFavourites_Click(object sender, EventArgs e)
        {
            string faveName = favouriteName.Text;
            string faveURL = favouriteURL.Text;

            bool faveExists = checkFavourite(favouriteName.Text);

            if (!String.IsNullOrEmpty(faveName) == true && !String.IsNullOrEmpty(faveURL) == true && faveExists == false)
            {
                File.AppendAllText(filenameFave, faveName + Environment.NewLine);
                File.AppendAllText(filenameFave, faveURL + Environment.NewLine);

                MessageBox.Show("Favourite successfully saved", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayFavourites();
            }

            // Display error message for relevant inputs
            else if (String.IsNullOrEmpty(faveName) == true && String.IsNullOrEmpty(faveURL) == true)
            {
                MessageBox.Show("Please enter in a URL and a Name", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(faveURL) == true)
            {
                MessageBox.Show("Please enter in a URL", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(faveName) == true)
            {
                MessageBox.Show("Please enter in a name for your new favourite", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (faveExists == true)
            {
                MessageBox.Show("That name already exists, please enter in a new name", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        // Change the name of a favourite
        private void editFavourites_Click(object sender, EventArgs e)
        {
            string currentName = faveNames1.GetItemText(faveNames1.SelectedItem);
            string newName = changeFavourites.Text;

            bool faveExists = checkFavourite(changeFavourites.Text);

            if (!String.IsNullOrEmpty(currentName) == true && !String.IsNullOrEmpty(newName) == true && faveExists == false)
            {
                string[] favourites = File.ReadAllLines(filenameFave);
                int i = 0;
                // Find the occurence of the name in the array and replace it with the new one
                do
                {
                    if (favourites[i].Equals(currentName))
                    {
                        favourites[i] = favourites[i].Replace(currentName, newName);
                        File.WriteAllLines(filenameFave, favourites);
                        break;
                    }

                    i += 2;
                } while (i < favourites.Length);

                MessageBox.Show("Favourite successfully changes", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the outputs to display new favourites
                changeFavourites.Clear();

                displayFavourites();

            }
            // Display relevant error messages 
            else if (faveExists == true)
            {
                MessageBox.Show("That name already exists, please enter in a new name", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(currentName) == true)
            {
                MessageBox.Show("Please select the favourite you would like to edit", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(newName) == true)
            {
                MessageBox.Show("Please enter the new name of the favourite", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Remove favourites by finding position in array, converting to list, removing relevant indexes from list, converting back to array then writing to external file
        private void removeFavourites_Click(object sender, EventArgs e)
        {
            string currentName = faveNames2.GetItemText(faveNames2.SelectedItem);

            if (String.IsNullOrEmpty(currentName) == false)
            {
                string[] favourites = File.ReadAllLines(filenameFave);
                int i = 0;
                do
                {
                    // Find index in array of current name
                    if (favourites[i].Equals(currentName))
                    {
                        // Convert to list to be able to remove it
                        var favouritesList = favourites.ToList();
                        favouritesList.RemoveAt(i);
                        favouritesList.RemoveAt(i);
                        string[] newfave = favouritesList.ToArray();
                        File.WriteAllLines(filenameFave, newfave);
                        break;
                    }
                    i += 2;
                } while (i < favourites.Length);

                MessageBox.Show("Favourite successfully removed", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                displayFavourites();
            } else
            // Display relevant error messages
            {
                MessageBox.Show("Please select a favourite to remove", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

     
        }

        // remove URL from history
        private void removeHistory_Click(object sender, EventArgs e)
        {
            string removeURL = historybox.GetItemText(historybox.SelectedItem);
            string[] historyURL = history.getHistory();

            int i = 0;
            if (removeURL != "")
            {
                do
                {
                    // Find index in array of specified URL
                    if (historyURL[i].Equals(removeURL))
                    {
                        // Convert the list them use .RemoveAt(i)
                        var historyList = historyURL.ToList();
                        historyList.RemoveAt(i);
                        string[] historyTemp = historyList.ToArray();
                        // Convert back to array and write to external txt file
                        File.WriteAllLines(filenameHistory, historyTemp);
                        MessageBox.Show("URL correctly removed", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayHistory();
                        break;
                    }
                    i++;
                } while (i < historyURL.Length);
            }

        }
    }
}
