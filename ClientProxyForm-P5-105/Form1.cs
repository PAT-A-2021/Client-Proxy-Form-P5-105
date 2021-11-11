using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxyForm_P5_105
{
    public partial class Form1 : Form
    {

        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhasil_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBox1.Text);
            int angka2 = Convert.ToInt32(textBox2.Text);

            double hasiltambah = obj.Tambah(angka1, angka2);
            double hasilkurang = obj.Kurang(angka1, angka2);
            double hasilkali = obj.Kali(angka1, angka2);
            double hasilbagi = obj.Bagi(angka1, angka2);

            labeljumlah.Text = hasiltambah.ToString();
            labelkurang.Text = hasilkurang.ToString();
            labelkali.Text = hasilkali.ToString();
            labelbagi.Text = hasilbagi.ToString();
        }
    }
}
