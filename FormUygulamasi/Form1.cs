using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private int fnTopla(int _Sayi1, int _Sayi2)
        {
            int sonuc = 0;

            sonuc = _Sayi1 + _Sayi2;

            return sonuc;
        }
        private int fnCikar(int _Sayi1, int _Sayi2)
        {
            return _Sayi1 - _Sayi2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkTopla.Checked == true)
            {
                int a1 = Convert.ToInt32(textBox1.Text);
                int a2 = Convert.ToInt32(textBox2.Text);

                int _Cevap = fnTopla(a1, a2);

                //int Sonuc = a1 + a2;
                label3.Text = _Cevap.ToString();

            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    int a1 = Convert.ToInt32(textBox1.Text);
                    int a2 = Convert.ToInt32(textBox2.Text);

                    int _Cevap = fnCikar(a1, a2);
                    label3.Text = _Cevap.ToString();

                }
                else
                {
                    if (checkBox3.Checked == true)
                    {
                        int a1 = Convert.ToInt32(textBox1.Text);
                        int a2 = Convert.ToInt32(textBox2.Text);
                        int Sonuc = a1 * a2;
                        label3.Text = Sonuc.ToString();

                    }
                    else
                    {
                        if (checkBox4.Checked == true)
                        {
                            int a1 = Convert.ToInt32(textBox1.Text);
                            int a2 = Convert.ToInt32(textBox2.Text);
                            int Sonuc = a1/a2;
                            label3.Text = Sonuc.ToString();

                        }
                    }
                }


            }
        }
    }
}
