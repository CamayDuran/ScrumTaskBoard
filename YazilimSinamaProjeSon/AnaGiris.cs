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
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show(); //form2 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
