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
    public partial class RDseferGoster : Form
    {
        public RDseferGoster()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");
        public static string GidenBilgiSeferTarihi;
        public static string GidenBilgiSeferNo;
        string GelenNereden=RezervasyonDegistir.GidecekBilgiSeferNereden;
        string GelenNereye=RezervasyonDegistir.GidecekBilgiSeferNereye;
        string GelenNeZaman=RezervasyonDegistir.GidecekBilgiSeferTarih;
        private void RDseferGoster_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("SeferBul", baglanti);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@kalkis", SqlDbType.VarChar).Value = GelenNereden;
            command.Parameters.AddWithValue("@varis", SqlDbType.VarChar).Value = GelenNereye;
            command.Parameters.AddWithValue("@tarih", SqlDbType.VarChar).Value = GelenNeZaman;
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dataGridView1.CurrentRow.Selected = true;

                GidenBilgiSeferNo = dataGridView1.Rows[e.RowIndex].Cells["SeferNo"].FormattedValue.ToString();
                GidenBilgiSeferTarihi = dataGridView1.Rows[e.RowIndex].Cells["SeferTarih"].FormattedValue.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sefer Seçildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
