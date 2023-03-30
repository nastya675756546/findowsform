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
    public partial class ZD3 : Form
    {
        public ZD3()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        string[] str;
        int[] n = new int[3];

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.Split(';');

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    n[i] = int.Parse(str[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверное значеиние");
                return;
            }

            if (n[0]>n[1] && n[0]>n[2])
            {

            }
            
        }
    }
}
