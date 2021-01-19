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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //Sql le bağlantı satırı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TVRHUSM\\MSSQLSERVER01;Initial Catalog=TaskBoard;Integrated Security=True");
        
        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView2.AllowDrop = true;
            dataGridView3.AllowDrop = true;
            dataGridView4.AllowDrop = true;
            dataGridView5.AllowDrop = true;
            // TODO: Bu kod satırı 'taskBoardDataSet2.TeknikKart' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teknikKartTableAdapter.Fill(this.taskBoardDataSet2.TeknikKart);
            // TODO: Bu kod satırı 'taskBoardDataSet1.isTakip' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.isTakipTableAdapter.Fill(this.taskBoardDataSet1.isTakip);
            SqlDataAdapter kart_data = new SqlDataAdapter("Select isinAciklamasi from TeknikKart", baglanti);
            DataSet ds1 = new DataSet();

            kart_data.Fill(ds1);

             dataGridView1.DataSource = ds1.Tables[0];
            
            //DataGridView de boş satır oluşturma 
            dataGridView2.Rows.Add();
            dataGridView2.Rows.Add();
            dataGridView2.Rows.Add();
            dataGridView2.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView4.Rows.Add();
            dataGridView4.Rows.Add();
            dataGridView4.Rows.Add();
            dataGridView4.Rows.Add();
            dataGridView5.Rows.Add();
            dataGridView5.Rows.Add();
            dataGridView5.Rows.Add();
            dataGridView5.Rows.Add();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            //verilerin koordinatlarını tutmak için değişken tanımladık
            int SourceRow;
            //Koordintları değişkene attık
            SourceRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            //Verinin kopyasını aldık
            dataGridView1.DoDragDrop(SourceRow, DragDropEffects.Copy);
            
        }
        
        private void dataGridView2_DragDrop_1(object sender, DragEventArgs e)
        {
            // konumu integer bir değişkene çevirdik
            int SourceRow = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
            //datagridview2 de seçilen yerin konumunu aldık
            Point clientPoint = dataGridView2.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hit = dataGridView2.HitTest(clientPoint.X, clientPoint.Y);
            if ((hit.Type == DataGridViewHitTestType.Cell))
            {
                //datagridview1 de secilen veriyi datagridview2 de seçilen yere aktarıyoruz
                int DestRow = hit.RowIndex;
                int DestCol = hit.ColumnIndex;
                dataGridView2.Rows[DestRow].Cells[DestCol].Value = dataGridView1.Rows[SourceRow].Cells[0].Value;
                dataGridView1.Rows[SourceRow].Cells[0].Value = null;
            }
        }

        private void dataGridView2_DragOver_1(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
 //**********************************************
      

        private void dataGridView3_DragDrop(object sender, DragEventArgs e)
        {
            int SourceRow = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
            Point clientPoint = dataGridView3.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hit = dataGridView3.HitTest(clientPoint.X, clientPoint.Y);
            if ((hit.Type == DataGridViewHitTestType.Cell))
            {
                int DestRow = hit.RowIndex;
                int DestCol = hit.ColumnIndex;
                dataGridView3.Rows[DestRow].Cells[DestCol].Value = dataGridView2.Rows[SourceRow].Cells[0].Value;
                dataGridView2.Rows[SourceRow].Cells[0].Value = null;
            }
        }

        private void dataGridView3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        //*******************************************************

        private void dataGridView4_DragDrop(object sender, DragEventArgs e)
        {
            int SourceRow = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
            Point clientPoint = dataGridView4.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hit = dataGridView4.HitTest(clientPoint.X, clientPoint.Y);
            if ((hit.Type == DataGridViewHitTestType.Cell))
            {
                int DestRow = hit.RowIndex;
                int DestCol = hit.ColumnIndex;
                dataGridView4.Rows[DestRow].Cells[DestCol].Value = dataGridView3.Rows[SourceRow].Cells[0].Value;
                dataGridView3.Rows[SourceRow].Cells[0].Value = null;
            }
        }

        private void dataGridView4_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        //*******************************************************
        private void dataGridView5_DragDrop(object sender, DragEventArgs e)
        {

            int SourceRow = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
            Point clientPoint = dataGridView5.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hit = dataGridView5.HitTest(clientPoint.X, clientPoint.Y);
            if ((hit.Type == DataGridViewHitTestType.Cell))
            {
                int DestRow = hit.RowIndex;
                int DestCol = hit.ColumnIndex;
                dataGridView5.Rows[DestRow].Cells[DestCol].Value = dataGridView4.Rows[SourceRow].Cells[0].Value;
                dataGridView4.Rows[SourceRow].Cells[0].Value = null;
            }
        }

        private void dataGridView5_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            int SourceRow;
            SourceRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            dataGridView2.DoDragDrop(SourceRow, DragDropEffects.Copy);
        }

        private void dataGridView3_MouseDown(object sender, MouseEventArgs e)
        {
            int SourceRow;
            SourceRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            dataGridView3.DoDragDrop(SourceRow, DragDropEffects.Copy);
        }

        private void dataGridView4_MouseDown(object sender, MouseEventArgs e)
        {
            int SourceRow;
            SourceRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            dataGridView4.DoDragDrop(SourceRow, DragDropEffects.Copy);
        }

        private void dataGridView5_MouseDown(object sender, MouseEventArgs e)
        {
            int SourceRow;
            SourceRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            dataGridView5.DoDragDrop(SourceRow, DragDropEffects.Copy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris form1 = new Giris();
            form1.Show(); //Giris göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }
    }
    }

