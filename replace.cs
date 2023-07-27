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
    public partial class replace : Form
    {
        public string stext;
        public string rtext;
        public replace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stext = textBox1.Text;
            rtext = textBox2.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
