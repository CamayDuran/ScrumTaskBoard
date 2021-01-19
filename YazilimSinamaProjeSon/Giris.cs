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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        

        private void buttonekle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); //form2 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); //form3 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }

        private void buttonliste_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            form4.Show(); //form4 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }
    }
}
