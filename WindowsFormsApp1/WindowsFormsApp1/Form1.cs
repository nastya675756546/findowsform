using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void вычисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd1.Show();
            this.Hide();
        }

        private void вычисленияВыраженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.zd2.Show();
            this.Hide();
        }

        private void лБ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
