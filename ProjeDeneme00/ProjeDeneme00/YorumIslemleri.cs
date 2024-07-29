using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace ProjeDeneme00
{
    public partial class YorumIslemleri : UserControl
    {
        public YorumIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");
        private void YorumIslemleri_Load(object sender, EventArgs e)
        {
            this.BackColor= Color.FromArgb(100, 0, 0, 0);

            seferListesiniGetir();



        }



        void seferListesiniGetir()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapterr = new SqlDataAdapter("Select * from viewYolcuYorumları", baglanti);
       
            DataTable dataTable1 = new DataTable();
            dataAdapterr.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
            baglanti.Close();
        }
        string YorumDegisID;

        private void YolcuYorumKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand connectioncommand = new SqlCommand("insert into yorumlar (YolcuTc,SeferID,yorum)values (@tc,@seferID,@ylcuYorum)", baglanti);
                connectioncommand.Parameters.AddWithValue("@tc", textYorumID.Text);
                connectioncommand.Parameters.AddWithValue("@seferID", textYorumSeferID.Text);
                connectioncommand.Parameters.AddWithValue("@ylcuYorum", textYorum.Text);

                connectioncommand.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Yorumunuz Kaydedildi!", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                seferListesiniGetir();
            }
            catch
            {
                MessageBox.Show("Eksik ya da yanlış bir TC girdiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dataGridView1.CurrentRow.Selected = true;

                YorumDegisID = dataGridView1.Rows[e.RowIndex].Cells["YorumID"].FormattedValue.ToString();

            }



        }
        String gelenYorum = YorumDegis.GidenGuncelYorum;
        private void buttonYorumDegistir_Click(object sender, EventArgs e)
        {

            YorumDegis yd = new YorumDegis();
            yd.ShowDialog();
            
            baglanti.Open();

            SqlCommand YorumGuncelle = new SqlCommand("Update yorumlar set yorum=@Yorum where YorumID=@yorumID",baglanti);
            YorumGuncelle.Parameters.AddWithValue("@Yorum", gelenYorum);
            YorumGuncelle.Parameters.AddWithValue("@yorumID",YorumDegisID);

            YorumGuncelle.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
