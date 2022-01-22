
namespace Browser
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homepageURL = new System.Windows.Forms.TextBox();
            this.homepageURLlabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.setHomepage = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.changeFavourites = new System.Windows.Forms.TextBox();
            this.editFavourites = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.faveNames1 = new System.Windows.Forms.ComboBox();
            this.removeFavourites = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.favouriteURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addFavourites = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.favouriteName = new System.Windows.Forms.TextBox();
            this.faveNames2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.removeHistory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.historybox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // homepageURL
            // 
            this.homepageURL.Location = new System.Drawing.Point(9, 35);
            this.homepageURL.Multiline = true;
            this.homepageURL.Name = "homepageURL";
            this.homepageURL.Size = new System.Drawing.Size(363, 34);
            this.homepageURL.TabIndex = 0;
            // 
            // homepageURLlabel
            // 
            this.homepageURLlabel.AutoSize = true;
            this.homepageURLlabel.Location = new System.Drawing.Point(6, 17);
            this.homepageURLlabel.Name = "homepageURLlabel";
            this.homepageURLlabel.Size = new System.Drawing.Size(102, 13);
            this.homepageURLlabel.TabIndex = 1;
            this.homepageURLlabel.Text = "Homepage URL:";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 327);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(73, 30);
            this.back.TabIndex = 3;
            this.back.Text = "<-";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 311);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.setHomepage);
            this.tabPage1.Controls.Add(this.homepageURL);
            this.tabPage1.Controls.Add(this.homepageURLlabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Homepage";
            // 
            // setHomepage
            // 
            this.setHomepage.Location = new System.Drawing.Point(387, 35);
            this.setHomepage.Name = "setHomepage";
            this.setHomepage.Size = new System.Drawing.Size(73, 30);
            this.setHomepage.TabIndex = 2;
            this.setHomepage.Text = "Apply ";
            this.setHomepage.UseVisualStyleBackColor = true;
            this.setHomepage.Click += new System.EventHandler(this.setHomepage_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.changeFavourites);
            this.tabPage2.Controls.Add(this.editFavourites);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.faveNames1);
            this.tabPage2.Controls.Add(this.removeFavourites);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.favouriteURL);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.addFavourites);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.favouriteName);
            this.tabPage2.Controls.Add(this.faveNames2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Favourites";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Change Name:";
            // 
            // changeFavourites
            // 
            this.changeFavourites.Location = new System.Drawing.Point(229, 131);
            this.changeFavourites.Multiline = true;
            this.changeFavourites.Name = "changeFavourites";
            this.changeFavourites.Size = new System.Drawing.Size(204, 21);
            this.changeFavourites.TabIndex = 12;
            // 
            // editFavourites
            // 
            this.editFavourites.Location = new System.Drawing.Point(9, 158);
            this.editFavourites.Name = "editFavourites";
            this.editFavourites.Size = new System.Drawing.Size(73, 30);
            this.editFavourites.TabIndex = 11;
            this.editFavourites.Text = "Edit";
            this.editFavourites.UseVisualStyleBackColor = true;
            this.editFavourites.Click += new System.EventHandler(this.editFavourites_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Edit Favourites:";
            // 
            // faveNames1
            // 
            this.faveNames1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faveNames1.FormattingEnabled = true;
            this.faveNames1.Location = new System.Drawing.Point(9, 131);
            this.faveNames1.Name = "faveNames1";
            this.faveNames1.Size = new System.Drawing.Size(204, 21);
            this.faveNames1.TabIndex = 9;
            // 
            // removeFavourites
            // 
            this.removeFavourites.Location = new System.Drawing.Point(9, 236);
            this.removeFavourites.Name = "removeFavourites";
            this.removeFavourites.Size = new System.Drawing.Size(73, 30);
            this.removeFavourites.TabIndex = 8;
            this.removeFavourites.Text = "Remove";
            this.removeFavourites.UseVisualStyleBackColor = true;
            this.removeFavourites.Click += new System.EventHandler(this.removeFavourites_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "URL:";
            // 
            // favouriteURL
            // 
            this.favouriteURL.Location = new System.Drawing.Point(229, 52);
            this.favouriteURL.Multiline = true;
            this.favouriteURL.Name = "favouriteURL";
            this.favouriteURL.Size = new System.Drawing.Size(204, 21);
            this.favouriteURL.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remove Favourites:";

            // 
            // addFavourites
            // 
            this.addFavourites.Location = new System.Drawing.Point(9, 79);
            this.addFavourites.Name = "addFavourites";
            this.addFavourites.Size = new System.Drawing.Size(73, 30);
            this.addFavourites.TabIndex = 3;
            this.addFavourites.Text = "Save";
            this.addFavourites.UseVisualStyleBackColor = true;
            this.addFavourites.Click += new System.EventHandler(this.addFavourites_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add New Favourite:";
            // 
            // favouriteName
            // 
            this.favouriteName.Location = new System.Drawing.Point(9, 52);
            this.favouriteName.Multiline = true;
            this.favouriteName.Name = "favouriteName";
            this.favouriteName.Size = new System.Drawing.Size(204, 21);
            this.favouriteName.TabIndex = 1;
            // 
            // faveNames2
            // 
            this.faveNames2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faveNames2.FormattingEnabled = true;
            this.faveNames2.Location = new System.Drawing.Point(9, 209);
            this.faveNames2.Name = "faveNames2";
            this.faveNames2.Size = new System.Drawing.Size(204, 21);
            this.faveNames2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.removeHistory);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.historybox);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(475, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // removeHistory
            // 
            this.removeHistory.Location = new System.Drawing.Point(387, 29);
            this.removeHistory.Name = "removeHistory";
            this.removeHistory.Size = new System.Drawing.Size(73, 30);
            this.removeHistory.TabIndex = 1;
            this.removeHistory.Text = "Remove";
            this.removeHistory.UseVisualStyleBackColor = true;
            this.removeHistory.Click += new System.EventHandler(this.removeHistory_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Remove from History:";
            // 
            // historybox
            // 
            this.historybox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.historybox.FormattingEnabled = true;
            this.historybox.Location = new System.Drawing.Point(9, 35);
            this.historybox.Name = "historybox";
            this.historybox.Size = new System.Drawing.Size(363, 21);
            this.historybox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(507, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.back);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox homepageURL;
        private System.Windows.Forms.Label homepageURLlabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox favouriteName;
        private System.Windows.Forms.ComboBox faveNames2;
        private System.Windows.Forms.Button setHomepage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addFavourites;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox favouriteURL;
        private System.Windows.Forms.Button removeFavourites;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox changeFavourites;
        private System.Windows.Forms.Button editFavourites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox faveNames1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox historybox;
        private System.Windows.Forms.Button removeHistory;
    }
}