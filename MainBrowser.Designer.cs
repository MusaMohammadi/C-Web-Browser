
using System;

namespace Browser
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.btnSearch = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.textboxOutput = new System.Windows.Forms.TextBox();
            this.forwardbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.homePage = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.favourites = new System.Windows.Forms.Button();
            this.historyload = new System.Windows.Forms.Button();
            this.bulkDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(511, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 41);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(196, 8);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(309, 40);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // textboxOutput
            // 
            this.textboxOutput.Location = new System.Drawing.Point(12, 54);
            this.textboxOutput.Multiline = true;
            this.textboxOutput.Name = "textboxOutput";
            this.textboxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxOutput.Size = new System.Drawing.Size(677, 298);
            this.textboxOutput.TabIndex = 2;
            // 
            // forwardbutton
            // 
            this.forwardbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardbutton.Font = new System.Drawing.Font("PMingLiU-ExtB", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardbutton.Location = new System.Drawing.Point(58, 7);
            this.forwardbutton.Name = "forwardbutton";
            this.forwardbutton.Size = new System.Drawing.Size(40, 41);
            this.forwardbutton.TabIndex = 3;
            this.forwardbutton.Text = "->";
            this.forwardbutton.UseVisualStyleBackColor = true;
            this.forwardbutton.Click += new System.EventHandler(this.forwardbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.Font = new System.Drawing.Font("PMingLiU-ExtB", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(12, 7);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(40, 41);
            this.backbutton.TabIndex = 4;
            this.backbutton.Text = "<-";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click_1);
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.Transparent;
            this.homePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage.BackgroundImage")));
            this.homePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePage.Font = new System.Drawing.Font("PMingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePage.Location = new System.Drawing.Point(104, 7);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(40, 41);
            this.homePage.TabIndex = 5;
            this.homePage.UseVisualStyleBackColor = false;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings.BackgroundImage")));
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.Color.Transparent;
            this.settings.Location = new System.Drawing.Point(150, 7);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(40, 41);
            this.settings.TabIndex = 6;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // favourites
            // 
            this.favourites.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favourites.BackgroundImage")));
            this.favourites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.favourites.Location = new System.Drawing.Point(557, 6);
            this.favourites.Name = "favourites";
            this.favourites.Size = new System.Drawing.Size(40, 41);
            this.favourites.TabIndex = 7;
            this.favourites.UseVisualStyleBackColor = true;
            this.favourites.Click += new System.EventHandler(this.favourites_Click);
            // 
            // historyload
            // 
            this.historyload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyload.BackgroundImage")));
            this.historyload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historyload.Location = new System.Drawing.Point(603, 6);
            this.historyload.Name = "historyload";
            this.historyload.Size = new System.Drawing.Size(40, 41);
            this.historyload.TabIndex = 8;
            this.historyload.UseVisualStyleBackColor = true;
            this.historyload.Click += new System.EventHandler(this.historyload_ClickAsync);
            // 
            // bulkDownload
            // 
            this.bulkDownload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulkDownload.BackgroundImage")));
            this.bulkDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulkDownload.Location = new System.Drawing.Point(649, 6);
            this.bulkDownload.Name = "bulkDownload";
            this.bulkDownload.Size = new System.Drawing.Size(40, 41);
            this.bulkDownload.TabIndex = 9;
            this.bulkDownload.UseVisualStyleBackColor = true;
            this.bulkDownload.Click += new System.EventHandler(this.bulkDownload_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(702, 362);
            this.Controls.Add(this.bulkDownload);
            this.Controls.Add(this.historyload);
            this.Controls.Add(this.favourites);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.forwardbutton);
            this.Controls.Add(this.textboxOutput);
            this.Controls.Add(this.input);
            this.Controls.Add(this.btnSearch);
            this.KeyPreview = true;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void input_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button forwardbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button favourites;
        private System.Windows.Forms.Button historyload;
        private System.Windows.Forms.Button bulkDownload;
        public System.Windows.Forms.TextBox textboxOutput;
    }
}

