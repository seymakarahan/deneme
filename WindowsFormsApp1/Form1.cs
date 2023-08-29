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

        private void button1_Click(object sender, EventArgs e)
        {
            string a1 = textBox1.Text;

            string a2 = textBox2.Text;

            int t1 = int.Parse(a1);
            int t2 = int.Parse(a2);

            int t3 = t1 + t2;

            textBox3.Text = t3.ToString();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b1 = textBox6.Text;
            string b2 = textBox5.Text;

            int c1 = int.Parse(b1);
            int c2 = int.Parse(b2);

            int c3 = c1 - c2;

            textBox4.Text = c3 + "";
        }
    }
}
