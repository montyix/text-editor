using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_editor
{
    public partial class Form1 : Form
    {
        string szoveg = null; //szoveg=text
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            SaveFileDialog SaveWindow = new SaveFileDialog();
            try
            {
                SaveWindow.ShowDialog();
                files.Save(SaveWindow.FileName, text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            OpenFileDialog OpenWindow = new OpenFileDialog();
            if (OpenWindow.ShowDialog() == DialogResult.OK)
            {
                text = files.Open(OpenWindow.FileName);
                richTextBox1.Text = text;
            }
            else {
                MessageBox.Show("Not goos file");
            }
        }

        private void openRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenWindow2 = new OpenFileDialog();
            if (OpenWindow2.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(OpenWindow2.FileName);
            }
            else
            {
                MessageBox.Show("Not good RTF file");
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search formSearch = new Search();
            if (formSearch.ShowDialog() == DialogResult.OK)
            {
                szoveg = richTextBox1.Text;
                counter = richTextBox1.Find(formSearch.stext);
            }
            else
            {
                MessageBox.Show("Error in the Search");
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replace formReplace = new replace();
            if (formReplace.ShowDialog() == DialogResult.OK)
            {
                szoveg = richTextBox1.Text;
                counter = richTextBox1.Find(formReplace.stext, 0);
                //richTextBox1.Text = formReplace.stext;
                string text1 = formReplace.stext;
                string text2 = formReplace.rtext;
                szoveg.Replace(text1, text2);
               //newtext.Replace(formReplace.stext, formReplace.rtext);
                richTextBox1.Text = szoveg.Replace(text1, text2);
            }
            else {

                MessageBox.Show("Error in the Replace");
            }
        }
    }
}
