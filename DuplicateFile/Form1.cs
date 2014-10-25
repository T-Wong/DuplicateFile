using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e) { }

        // Updates a text box with the selected path
        public void ChooseFolder(TextBox textBox)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void folder1Button_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = folder1TextBox.Text;
            ChooseFolder(folder1TextBox);
        }

        private void folder2Button_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = folder2TextBox.Text;
            ChooseFolder(folder2TextBox);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Name: Duplicate File Finder\nMade By: Tyler Wong\nE-Mail: Ty-W@live.com\nGithub:T-Wong\n\nThanks for downloading my program!"
                , "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
