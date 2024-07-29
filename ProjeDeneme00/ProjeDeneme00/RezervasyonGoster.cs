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
    public partial class RezervasyonGoster : Form
    {
        public RezervasyonGoster()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");
        private void RezervasyonGoster_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            
        }
        int OneOrNull;

        void seferListesiniGetir()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapterr = new SqlDataAdapter("Select * from viewYolcuRezarvasyon where YolcuTcNo=@TC", baglanti);
            dataAdapterr.SelectCommand.Parameters.AddWithValue("@TC", textcGoster.Text);
            DataTable dataTable1 = new DataTable();
            dataAdapterr.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
            baglanti.Close();
        }
        private void ButonBulGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("Kontrol", baglanti);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TC", SqlDbType.VarChar).Value = textcGoster.Text;

            SqlParameter valueReturn = new SqlParameter("@sayac", SqlDbType.Int);
            valueReturn.Direction = ParameterDirection.ReturnValue;
            command.Parameters.Add(valueReturn);

            command.ExecuteReader();
            OneOrNull = (int)command.Parameters["@sayac"].Value;


            baglanti.Close();


            if (OneOrNull == 1)
            {

                MessageBox.Show("Rezervasyonunuz bulundu!", "Bilgilendirme", MessageBoxButtons.OK);
                seferListesiniGetir();
                dataGridView1.Show();

                



            }
            else
            {
                MessageBox.Show("Üzgünüz Herhangi bir Kaydınız bulunmamaktadır. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
