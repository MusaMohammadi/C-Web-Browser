using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Browser
{
    public partial class History : Form
    {
        // Filename of history.txt file
        string filenameHistory = Directory.GetCurrentDirectory() + "\\history.txt";
        public int index;

        private string url;

        public string getURL()
        {
            return url;
        }

        public void setURL(string _url)
        {
            url = _url;
        }


        public History()
        {
            InitializeComponent();
        }

        // Load history from txt file into listview box
        private void History_Load(object sender, EventArgs e)
        {
            historyview.Clear();
            string[] history = new String[] { };
            history = getHistory();
            historyview.Columns.Add("URL:",550);

            for (int i = 0; i < history.Length; i ++)
            {
                ListViewItem itm = new ListViewItem(history[i].ToString());
                historyview.Items.Add(itm);
            }
        }


        // Takes in a url and saves it to the external history.txt file
        public void saveURL(string url)
        {
            File.AppendAllText(filenameHistory, url + Environment.NewLine);
            index = getHistoryIndex() - 1;
        }

        // Retrieves the history and assigns it to an array of strings
        public string[] getHistory()
        {
            return (File.ReadAllLines(filenameHistory));
        }

        public int getHistoryIndex()
        {
            return getHistory().Length;
        }

        // Return the URL of the previous page in the history list relative to the current page in the history list
        public string getPreviousPage()
        {
            string[] temp = getHistory();
            if (index-1 < 0)
            {
               return temp[index];
            } else
            {
                index = index -1;
                return temp[index];
            }
        }

        // Return the URL of the next page relative to the current page in the history list
        public string getNextPage()
        {
            string[] temp = getHistory();
            if (index+1 >= temp.Length)
            {
                return temp[index];
            } else
            {
                index++;
                return temp[index];
            }
        }

        // Go back to main form
        private void back_Click_1(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Close();
        }

        // Load specified URl, throw exception if none are selected
        private void loadpage_Click(object sender, EventArgs e)
        {

            mainWindow main = new mainWindow();
            try
            {
                string url = historyview.SelectedItems[0].Text;

                // add to history
                saveURL(url);

                // call setter so mainbrowser can retrieve URL
                setURL(url);

                this.Close();

            } catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a valid link in history", "History", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        }

    }

