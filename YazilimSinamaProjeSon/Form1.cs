using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaProjeSon
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

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (txtpassworld.Text == "1111")//textboxa 1111 şifresini girince  Giris formuna gidecek
                {
                    Giris gk = new Giris();
                    gk.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış şifre lütfen tekrar deneyniz....");//Farklı bir şifre girilirse ekrana bu mesaj gelecek
                }
            
        }
    }
}
