using ClassLibrary1;
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

       
        private int fnCikar(int _Sayi1, int _Sayi2)
        {
            return _Sayi1 - _Sayi2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkTopla.Checked == true)
            {
                string a1 = textBox1.Text;
                string a2 = textBox2.Text;
               
                Matematik myClass = new Matematik();
                
                //Request Class'ı Dolduruldu.
                requestfntopla _Gidecek = new requestfntopla();
                _Gidecek.sayi1 = a1;
                _Gidecek.sayi2 = a2;



                ToplamaIslemSonuc gelen = myClass.fn_Topla(_Gidecek);
                if(gelen._Yanit == Durum.HataVar)
                {
                    MessageBox.Show("" + gelen._HataAciklama, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else
                {
                    label3.Text = gelen._Cevap.ToString();


                }


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
                            Matematik myClass = new Matematik();

                            int _Cevap = myClass.fn_Bolme(a1, a2);
                            label3.Text = _Cevap.ToString();

                        }
                    }
                }


            }
        }
    }
}
