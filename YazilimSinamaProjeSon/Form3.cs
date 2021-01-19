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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //Sql e bağlanmak için baglantı satırı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TVRHUSM\\MSSQLSERVER01;Initial Catalog=TaskBoard;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            //isTakip tablosundaki tüm verileri datagridView e getirir
            SqlDataAdapter is_data= new SqlDataAdapter("Select * from isTakip", baglanti);
            //TeknikKart tablosundaki tüm verileri datagridView e getirir
            SqlDataAdapter kart_data = new SqlDataAdapter("Select * from TeknikKart", baglanti);
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            is_data.Fill(ds1);
            kart_data.Fill(ds2);
            
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView2.DataSource = ds2.Tables[0];
        }

        private void btn_maasguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //İsTakip tablosundaki Durum bilgisinin girilen id deki durumu girilen durum bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update isTakip set Durum=@yenidurum where ID=@id ", baglanti);
            guncelle.Parameters.AddWithValue("@yenidurum", textBox_yenimaas.Text);
            guncelle.Parameters.AddWithValue("@id", textBox_id.Text);
            guncelle.ExecuteNonQuery();
            //Girilen yeni Durum bilgisinden sonra isTakip tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from isTakip ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void btn_tarihGunuGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //İsTakip tablosundaki Tarih bilgisinin girilen id deki tarihi girilen tarih bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update isTakip set Tarih=@yeniTarih where ID=@id ", baglanti);
            guncelle.Parameters.AddWithValue("@yeniTarih", textBox_tarih.Text);
            guncelle.Parameters.AddWithValue("@id", textBox1.Text);
            guncelle.ExecuteNonQuery();

            //Girilen yeni Tarih bilgisinden sonra isTakip tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from isTakip ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void buttonYapilacakis_Click(object sender, EventArgs e)
        {
            baglanti.Open();
                SqlCommand guncelle = new SqlCommand("Update isTakip set Yapilacakis=@yeniYapilacakis where ID=@id ", baglanti);
            guncelle.Parameters.AddWithValue("@yeniYapilacakis", textBoxYapilacakis.Text);
            guncelle.Parameters.AddWithValue("@id", textBoxid3.Text);
            guncelle.ExecuteNonQuery();

            //Girilen yeni Yapilacakis bilgisinden sonra isTakip tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from isTakip ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void buttonaciklama_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //İsTakip tablosundaki aciklama bilgisinin girilen id deki aciklamayi girilen aciklama bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update isTakip set Aciklama=@yeniAciklama where ID=@id ", baglanti);
            guncelle.Parameters.AddWithValue("@yeniAciklama", textBoxaciklama.Text);
            guncelle.Parameters.AddWithValue("@id", textBoxid4.Text);
            guncelle.ExecuteNonQuery();

            //Girilen yeni aciklama bilgisinden sonra isTakip tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from isTakip ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void buttontarih2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //TeknikKart tablosundaki Tarih bilgisinin girilen id deki tarihi girilen tarih bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update TeknikKart set Tarih=@yeniTarih where KartNo=@kartno ", baglanti);
            guncelle.Parameters.AddWithValue("@yeniTarih", textBoxTarih2.Text);
            guncelle.Parameters.AddWithValue("@kartno", textBoxNo1.Text);
            guncelle.ExecuteNonQuery();

            //Girilen yeni aciklama bilgisinden sonra TeknikKart tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from TeknikKart ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void buttonProjeAdi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //TeknikKart tablosundaki ProjeNoAdi bilgisinin girilen id deki ProjeNoAdinı girilen ProjeNoAdi bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update TeknikKart set ProjeNoAdi=@yeniProjeAdi where KartNo=@kartno ", baglanti);
            guncelle.Parameters.AddWithValue("@yeniProjeAdi", textBoxProjeAdi.Text);
            guncelle.Parameters.AddWithValue("@kartno", textBoxNo2.Text);
            guncelle.ExecuteNonQuery();

            //Girilen yeni ProjeNoAdi bilgisinden sonra TeknikKart tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from TeknikKart ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void buttonTeknikUzman_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //TeknikKart tablosundaki TeknikUzman bilgisinin girilen id deki TeknikUzmanı girilen TeknikUzman bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update TeknikKart set TeknikUzman=@yeniTeknikUzman where KartNo=@kartno ", baglanti);
            guncelle.Parameters.AddWithValue("@yeniTeknikUzman", textBoxTeknikUzman.Text);
            guncelle.Parameters.AddWithValue("@kartno", textBoxNo3.Text);
            guncelle.ExecuteNonQuery();

            //Girilen yeni TeknikUzman bilgisinden sonra TeknikKart tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from TeknikKart ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void buttonAciklama2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //TeknikKart tablosundaki isinAciklamasi bilgisinin girilen id deki isinAciklamasinı girilen isinAciklamasi bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update TeknikKart set isinAciklamasi=@yeniaciklama where KartNo=@kartno ", baglanti);
            guncelle.Parameters.AddWithValue("@yeniaciklama", textBoxaciklama2.Text);
            guncelle.Parameters.AddWithValue("@kartno", textBoxNo4.Text);
            guncelle.ExecuteNonQuery();

            //Girilen yeni isinAciklamasi bilgisinden sonra TeknikKart tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from TeknikKart ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void buttonNotlar_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //TeknikKart tablosundaki Notlar bilgisinin girilen id deki Notları girilen Notlar bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update TeknikKart set Notlar=@yeniNotlar where KartNo=@kartno ", baglanti);
            guncelle.Parameters.AddWithValue("@yeniNotlar", textBoxNotlar.Text);
            guncelle.Parameters.AddWithValue("@kartno", textBoxNo5.Text);
            guncelle.ExecuteNonQuery();

            //Girilen yeni Notlar bilgisinden sonra TeknikKart tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from TeknikKart ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void buttonGerceklesenSure_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //TeknikKart tablosundaki GerceklesenSure bilgisinin girilen id deki GerceklesenSureyi girilen GerceklesenSure bilgisiyle değiştirir
            SqlCommand guncelle = new SqlCommand("Update TeknikKart set GerceklesenSure=@yeniGerceklesenSure where KartNo=@kartno ", baglanti);
            guncelle.Parameters.AddWithValue("@yeniGerceklesenSure", textBoxGerceklesenSure.Text);
            guncelle.Parameters.AddWithValue("@kartno", textBoxNo6.Text);
            guncelle.ExecuteNonQuery();

            //Girilen yeni isinAciklamasi bilgisinden sonra TeknikKart tablosunun güncel halini ekrana yazdırır
            SqlDataAdapter goster = new SqlDataAdapter("Select * from TeknikKart ", baglanti);
            DataSet ds = new DataSet();
            goster.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris form1 = new Giris();
            form1.Show(); //Giris göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }
    }
}
