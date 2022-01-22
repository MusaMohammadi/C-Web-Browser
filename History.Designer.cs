
namespace Browser
{
    partial class History
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
            this.historyview = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.loadpage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyview
            // 
            this.historyview.HideSelection = false;
            this.historyview.Location = new System.Drawing.Point(6, 5);
            this.historyview.Name = "historyview";
            this.historyview.Size = new System.Drawing.Size(518, 358);
            this.historyview.TabIndex = 0;
            this.historyview.UseCompatibleStateImageBehavior = false;
            this.historyview.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(6, 369);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(73, 30);
            this.back.TabIndex = 2;
            this.back.Text = "<-";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // loadpage
            // 
            this.loadpage.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadpage.Location = new System.Drawing.Point(449, 369);
            this.loadpage.Name = "loadpage";
            this.loadpage.Size = new System.Drawing.Size(73, 30);
            this.loadpage.TabIndex = 3;
            this.loadpage.Text = "Load Page ";
            this.loadpage.UseVisualStyleBackColor = true;
            this.loadpage.Click += new System.EventHandler(this.loadpage_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(531, 412);
            this.Controls.Add(this.loadpage);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historyview);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(770, 70);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView historyview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button loadpage;
    }
}