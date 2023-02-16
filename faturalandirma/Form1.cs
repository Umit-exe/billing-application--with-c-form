using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faturalandirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string aboneNo = textBox1.Text;
            double kullanimMiktari = Convert.ToDouble(textBox2.Text);
            string kullanimTürü = textBox3.Text;
            double meskenSabit = 1.62;
            double ticariSabit = 1.21;
            double endüstriyelSabit = 0.98;
            double tutar = 0;
            if (aboneNo.Length != 6)
            {
                MessageBox.Show("Abone numarası 6 haneli olmalıdır!");
                textBox1.Clear();
            }
            else
            {
                switch (kullanimTürü)
                {
                    case "M":
                    case "m":
                        {
                            tutar = meskenSabit * kullanimMiktari;
                        }
                        break;
                    case "T":
                    case "t":
                        {
                            tutar = ticariSabit * kullanimMiktari;
                        }
                        break;
                    case "E":
                    case "e":
                        {
                            tutar = endüstriyelSabit * kullanimMiktari;
                        }
                        break;
                    default:
                        MessageBox.Show("Geçersiz kullanım türü!");
                        textBox3.Clear();
                        goto git;
                        break;
                }
                MessageBox.Show(aboneNo + " numaralı kullanıcımız fatura tutarınız " + tutar + " Türk Lirasıdır.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                tutar = 0;
            git:;
            }
        }
    }
}
