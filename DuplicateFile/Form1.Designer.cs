namespace DuplicateFile
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.folder1TextBox = new System.Windows.Forms.TextBox();
            this.folder1Button = new System.Windows.Forms.Button();
            this.folder1Label = new System.Windows.Forms.Label();
            this.folder2Label = new System.Windows.Forms.Label();
            this.folder2Button = new System.Windows.Forms.Button();
            this.folder2TextBox = new System.Windows.Forms.TextBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(433, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // folder1TextBox
            // 
            this.folder1TextBox.Location = new System.Drawing.Point(63, 24);
            this.folder1TextBox.Name = "folder1TextBox";
            this.folder1TextBox.Size = new System.Drawing.Size(261, 20);
            this.folder1TextBox.TabIndex = 2;
            // 
            // folder1Button
            // 
            this.folder1Button.Location = new System.Drawing.Point(330, 22);
            this.folder1Button.Name = "folder1Button";
            this.folder1Button.Size = new System.Drawing.Size(91, 23);
            this.folder1Button.TabIndex = 3;
            this.folder1Button.Text = "Choose Folder";
            this.folder1Button.UseVisualStyleBackColor = true;
            this.folder1Button.Click += new System.EventHandler(this.folder1Button_Click);
            // 
            // folder1Label
            // 
            this.folder1Label.AutoSize = true;
            this.folder1Label.Location = new System.Drawing.Point(12, 27);
            this.folder1Label.Name = "folder1Label";
            this.folder1Label.Size = new System.Drawing.Size(45, 13);
            this.folder1Label.TabIndex = 4;
            this.folder1Label.Text = "Folder 1";
            // 
            // folder2Label
            // 
            this.folder2Label.AutoSize = true;
            this.folder2Label.Location = new System.Drawing.Point(12, 57);
            this.folder2Label.Name = "folder2Label";
            this.folder2Label.Size = new System.Drawing.Size(45, 13);
            this.folder2Label.TabIndex = 7;
            this.folder2Label.Text = "Folder 2";
            // 
            // folder2Button
            // 
            this.folder2Button.Location = new System.Drawing.Point(330, 52);
            this.folder2Button.Name = "folder2Button";
            this.folder2Button.Size = new System.Drawing.Size(91, 23);
            this.folder2Button.TabIndex = 6;
            this.folder2Button.Text = "Choose Folder";
            this.folder2Button.UseVisualStyleBackColor = true;
            this.folder2Button.Click += new System.EventHandler(this.folder2Button_Click);
            // 
            // folder2TextBox
            // 
            this.folder2TextBox.Location = new System.Drawing.Point(63, 54);
            this.folder2TextBox.Name = "folder2TextBox";
            this.folder2TextBox.Size = new System.Drawing.Size(261, 20);
            this.folder2TextBox.TabIndex = 5;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 261);
            this.Controls.Add(this.folder2Label);
            this.Controls.Add(this.folder2Button);
            this.Controls.Add(this.folder2TextBox);
            this.Controls.Add(this.folder1Label);
            this.Controls.Add(this.folder1Button);
            this.Controls.Add(this.folder1TextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicate File Finder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox folder1TextBox;
        private System.Windows.Forms.Button folder1Button;
        private System.Windows.Forms.Label folder1Label;
        private System.Windows.Forms.Label folder2Label;
        private System.Windows.Forms.Button folder2Button;
        private System.Windows.Forms.TextBox folder2TextBox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

