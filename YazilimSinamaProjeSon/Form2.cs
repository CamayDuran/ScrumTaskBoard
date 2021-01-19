using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace YazilimSinamaProjeSon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int tahminiSure = 0;
        //Sql e bağlantı değişkeniyle bağlandı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TVRHUSM\\MSSQLSERVER01;Initial Catalog=TaskBoard;Integrated Security=True");
             

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //TextBox taki verileri Sql deki isTakip tablosuna kaydediyor
            SqlCommand yazdir2 = new SqlCommand("Insert Into isTakip (Tarih,Durum,Yapilacakis,Aciklama) Values ('" + txtitarih1.Text.ToString() + "','" + txtdurum1.Text + "','" + txtis1.Text.ToString() + "','" + txtaciklama1.Text.ToString() + "')", baglanti);
            yazdir2.ExecuteNonQuery();
            SqlCommand yazdir3 = new SqlCommand("Insert Into isTakip (Tarih,Durum,Yapilacakis,Aciklama) Values ('" + txtitarih2.Text.ToString() + "','" + txtdurum2.Text + "','" + txtis2.Text.ToString() + "','" + txtaciklama2.Text.ToString() + "')", baglanti);
            yazdir3.ExecuteNonQuery();
            SqlCommand yazdir4 = new SqlCommand("Insert Into isTakip (Tarih,Durum,Yapilacakis,Aciklama) Values ('" + txtitarih3.Text.ToString() + "','" + txtdurum3.Text + "','" + txtis3.Text.ToString() + "','" + txtaciklama3.Text.ToString() + "')", baglanti);
            yazdir4.ExecuteNonQuery();
            SqlCommand yazdir5 = new SqlCommand("Insert Into isTakip (Tarih,Durum,Yapilacakis,Aciklama) Values ('" + txtitarih4.Text.ToString() + "','" + txtdurum4.Text + "','" + txtis4.Text.ToString() + "','" + txtaciklama4.Text.ToString() + "')", baglanti);
            yazdir5.ExecuteNonQuery();
            SqlCommand yazdir6 = new SqlCommand("Insert Into isTakip (Tarih,Durum,Yapilacakis,Aciklama) Values ('" + txtitarih5.Text.ToString() + "','" + txtdurum5.Text + "','" + txtis5.Text.ToString() + "','" + txtaciklama5.Text.ToString() + "')", baglanti);
            yazdir6.ExecuteNonQuery();

            SqlCommand yazdir = new SqlCommand("Insert Into TeknikKart (Tarih,KartNo,ProjeNoAdi,TeknikUzman,isinAciklamasi,Notlar) Values ('" + txtTarih.Text.ToString() + "','" + txtKartNo.Text + "','" + txtProjeNo.Text.ToString() + "','" + txtTeknikUzman.Text.ToString() + "','" + txtisinAciklamasi.Text.ToString() + "','" + txtNotlar.Text.ToString() + "')", baglanti);
            yazdir.ExecuteNonQuery();

            //Tahmini süre değişkeninin içine  yapılacak iş textBoxlarındaki bilgileri atıyoruz
            TahminiSureHesapla(txtis1.Text, txtis2.Text, txtis3.Text, txtis4.Text, txtis5.Text);

            //Girilen yapılacak iş sayısı başına 1 gün süre verip hesaplanan değeri Sql e kaydediyor
            SqlCommand yazdirz = new SqlCommand("UPDATE TeknikKart SET TahminiSure=" + tahminiSure + " where KartNo=" + txtKartNo.Text + " ", baglanti);
            yazdirz.ExecuteNonQuery();

            baglanti.Close();
        }
        public int TahminiSureHesapla(string yapilacakis1, string yapilacakis2, string yapilacakis3, string yapilacakis4, string yapilacakis5)
        {
            //yapılacak iş textboxlarınının dolu olup olmamasına göre İşin tahmini bitmr süresini hesaplıyor
            if (yapilacakis1 != "" && yapilacakis2 == "")
            {
                tahminiSure = 1;

            }
            else if (yapilacakis2 != "" && yapilacakis3 == "")
            {
                tahminiSure = 2;

            }
            else if (yapilacakis3 != "" && yapilacakis4 == "")
            {
                tahminiSure = 3;

            }
            else if (yapilacakis4 != "" && yapilacakis5 == "")
            {
                tahminiSure = 4;

            }
            else
            {
                tahminiSure = 5;
            }
            return tahminiSure;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Giris form1 = new Giris();
            form1.Show(); //Giris göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
