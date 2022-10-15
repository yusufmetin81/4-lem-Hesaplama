using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a, b, toplam;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            toplam = a + b;

            label4.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, çıkarma;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            çıkarma = a - b;

            label4.Text = çıkarma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, çarpma;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            çarpma = a * b;

            label4.Text = çarpma.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, bölme;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            bölme = a / b;

            label4.Text = bölme.ToString();
        }
    }
}
