using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakulteOkulNot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = textBox1.Text;
            b = (a.Substring(4, 2));//yazınca indis
            c = b;

            if (c == "13")
                listBox2.Items.Add("Mühendislik Fakültesi");

            else if (c == "14")
                listBox2.Items.Add("Eğitim Fakültesi");

            else if (c == "15")
                listBox2.Items.Add("Fen & Edebiyat Fakültesi");

            else if (c == "16")
                listBox2.Items.Add("İktisadi ve İdari Bilimler Fakültesi");

            int vize = Convert.ToInt32(textBox4.Text);
            int final = Convert.ToInt32(textBox5.Text);

            if (vize > 100 || vize < 0)
            {
                MessageBox.Show("Yok böyle bir not!");
            }
            if (final > 100 || vize < 0)
            {
                MessageBox.Show("Yok böyle bir not!");
            }

            double ortalama = (vize * 0.4) + (final * 0.6);

            listBox4.Items.Add(ortalama);//rakamsal ortalama

            if (ortalama >= 89.5 && ortalama <= 100)
            {
                listBox5.Items.Add("AA");
            }
            else if (ortalama >= 69.5 && ortalama <= 89.5)
            {
                listBox5.Items.Add("BB");
            }
            else if (ortalama >= 50.0 && ortalama <= 69.5)
            {
                listBox5.Items.Add("CC");
            }
            else if (ortalama >= 0.0 && ortalama < 50)
            {
                listBox5.Items.Add("FF");
            }

            listBox3.Items.Add(textBox2.Text + " " + textBox3.Text);

            string d = textBox1.Text; //öğr numarası alırız
            string girisyilsonrakam, girisyili;
            girisyilsonrakam = (d.Substring(2, 2));
            girisyili = "20" + girisyilsonrakam;
            listBox1.Items.Add(girisyili);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}