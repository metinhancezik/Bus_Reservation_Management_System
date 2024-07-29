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
    public partial class SoforSil : Form
    {
        public SoforSil()
        {
            InitializeComponent();
        }


        int OneOrNUll;
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");
        private void buttonKaptanSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand command2 = new SqlCommand("KontrolSoforSil", baglanti);
            command2.CommandType = CommandType.StoredProcedure;
            command2.Parameters.AddWithValue("@kaptanIsmi", SqlDbType.VarChar).Value = textkaptanNOsil.Text;

            SqlParameter valueReturn2 = new SqlParameter("@sayacımSofor", SqlDbType.Int);
            valueReturn2.Direction = ParameterDirection.ReturnValue;
            command2.Parameters.Add(valueReturn2);

            command2.ExecuteReader();
            OneOrNUll = (int)command2.Parameters["@sayacımSofor"].Value;


            baglanti.Close();

            if (OneOrNUll == 1)

            {
                baglanti.Open();

                SqlCommand SoforSil = new SqlCommand("Delete from soforBilgileri where KaptanNo = @soforID", baglanti);
                SoforSil.Parameters.AddWithValue("@soforID", textkaptanNOsil.Text);

                SoforSil.ExecuteNonQuery();

                MessageBox.Show("Şoför Silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglanti.Close();
            }
            else
            {

                MessageBox.Show("Böyle bir şoför mevcut değil", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SoforSil_Load(object sender, EventArgs e)
        {

        }
    }
}
