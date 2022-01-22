using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class mainWindow : Form
    {
        // Delcare filename variable and instance of history class
        string filenameHomepage = Directory.GetCurrentDirectory() + "\\homepage.txt";
        History history = new History();

        public mainWindow()
        {
            InitializeComponent();
        }

        // Create key bindings
        private void mainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            // Call homepage if CTRL+H
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.H)
            {
                gethomepage();

            // Call favourites if CTRL+F
            } else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
            {
                load_favourites();

            // Call settings if CTRL+S
            }else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                load_settings();
            }
        }

        // Load the homepage on form load
        private void mainWindow_Load(object sender, EventArgs e)
        {
            gethomepage();
            this.Enabled = true;
        }

        // Get the homepage and display it
        private void gethomepage()
        {
            // If first boot, create homepage file and set default
            if (!File.Exists(filenameHomepage))
            {
                File.WriteAllText(filenameHomepage, "https://www2.macs.hw.ac.uk/~mm347/");
            }

            // Get homepage
            string homepage = File.ReadAllText(filenameHomepage);

            // Add to history
            history.saveURL(homepage);

            // Display page
            string output = getPage(homepage);

            var title = GetTitle(output);

            displayPage(title, output, homepage);
        }

        // Set the title of the form
        private void setTitle(Match title, string response)
        {
            if (title == null)
            {
                this.Text = response;
            }
            else
            {
                this.Text = title.ToString();
            }
        }

        // Load a page specified from the search bar
        private void btnTest_Click(object sender, EventArgs e)
        {

            textboxOutput.Clear();

            string url = input.Text;

            // add to history
            history.saveURL(url);

            // Display page
            string output = getPage(url);

            var title = GetTitle(output);

            displayPage(title, output, url);
        }

        // Sets the title, and outputs the code to the text box
        public void displayPage(Match title, string output, string url)
        {
            setTitle(title, output);
            textboxOutput.Clear();
            textboxOutput.Text += (output);
            input.Text = url;
        }

        // get the http response and status code
        public string getPage(string url)
        {
            HTTP http = new HTTP();
            string output = http.Get(url);
            string code = http.getCode(url);
            if (code == "OK 200")
            {
                return code + output;
            }
            return output;
        }

        // Using a regex, return the title of the page
        public Match GetTitle(String response)
        {
            // regex to match all data between the <title></title> tags
            Regex rg = new Regex(@"(?<=<title>)\s*(.+?)\s*(?=</title>)");

            Match output = rg.Match(response);

            return output.Success ? output : null;
        }

        // open homepage
        private void homePage_Click(object sender, EventArgs e)
        {
            gethomepage();
        }

        // Open the settings form
        private void load_settings()
        {
            this.Enabled = false;
            Settings settings_form = new Settings();
            settings_form.ShowDialog();
            settings_form.Enabled = true;
            this.Enabled = true;
        }

        // call load settings function 
        private void settings_Click(object sender, EventArgs e)
        {
            load_settings();
        }

        // Load favourites form
        private void load_favourites()
        {
            this.Enabled = false;
            Favourites favourites_form = new Favourites();
            favourites_form.ShowDialog();
            favourites_form.Enabled = true;

            // if the url from favourites contains a value, load the url
            if (String.IsNullOrEmpty(favourites_form.getURL()) == false)
            {
                string output = getPage(favourites_form.getURL());

                var title = GetTitle(output);

                displayPage(title, output, favourites_form.getURL());

            }
            this.Enabled = true;
        }

        // call load favourites function 
        private void favourites_Click(object sender, EventArgs e)
        {
            load_favourites();
        }

        // Load the history
        private void historyload_ClickAsync(object sender, EventArgs e)
        {
            this.Enabled = false;
            history.Enabled = true; 
            history.ShowDialog(this);

            // if the url from history contains a value, load the url
            if (String.IsNullOrEmpty(history.getURL()) == false)
            {
                string output = getPage(history.getURL());

                var title = GetTitle(output);

                displayPage(title, output, history.getURL());

            }
            this.Enabled = true;
        }

        // Load the previous page in history
        private void backbutton_Click_1(object sender, EventArgs e)
        {
            string url = history.getPreviousPage(); 

            string output = getPage(url);

            var title = GetTitle(output);

            displayPage(title, output, url);  
        }

        // Load the next page in history
        private void forwardbutton_Click(object sender, EventArgs e)
        {
            string url = history.getNextPage();

            string output = getPage(url);

            var title = GetTitle(output);

            displayPage(title, output, url); 
        }

        // retrieve the data for bulk download
        private void getBulkDownload(string file)
        {
            HTTP http = new HTTP();
            string code;
            textboxOutput.Clear();
            input.Clear();
            this.Text = "Bulk Download";

            List<String> urlList = new List<string>();
            string[] output = new string[] { };

            // Loop for all the URLS in the file 
            foreach (string url in File.ReadAllLines(file))
            {
                // get the code of the url
                code = http.getCode(url);
                // get the response to be able to get the byte count
                string response = http.Get(url);
                int bytes = System.Text.ASCIIEncoding.Unicode.GetByteCount(response);
                // display everything
                textboxOutput.AppendText("Status Code:" + code + " Bytes: " + bytes + " URL: " + url + System.Environment.NewLine);
            }
        }

        // Initalise bulk download on first run
        private void initialiseBulkDownload()
        {
            // set filename for bulk.txt
            string filename = Directory.GetCurrentDirectory() + "\\bulk.txt";
            // if file does not exist, create file
            if (!File.Exists(filename))
            {
                string urls = "https://www.bbc.co.uk/news" + System.Environment.NewLine + "https://www.facebook.com/" + System.Environment.NewLine + "http://status.savanttools.com/?code=403";
                File.AppendAllText(filename, urls);
                getBulkDownload(filename);

            } else
            {
                // Display contents of file
                getBulkDownload(filename);
            }
        }

        private void bulkDownload_Click(object sender, EventArgs e)
        {
            // ask if user wants to use their own bulk download file
            DialogResult inputMethod = MessageBox.Show("Do you wish to use your own file for bulk downloads?", "Bulk Downloads", MessageBoxButtons.YesNo);
            // if yes, open file dialog and pass the filename to the getBulkDownload
            if (inputMethod == DialogResult.Yes)
            {
                string file;
                OpenFileDialog picker = new OpenFileDialog();
                DialogResult result = picker.ShowDialog();

                if (result == DialogResult.OK)
                {
                    file = picker.FileName;
                    getBulkDownload(file);
                }
                else
                {
                    MessageBox.Show("Please select a file to initiate the bulk downloads", "Bulk Downloads", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else
            {
                initialiseBulkDownload();
            }
        }
    }
}

