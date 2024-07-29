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
    public partial class SeferSil : Form
    {
        public SeferSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");

        int OneOrNUll;
        private void SeferSil_Load(object sender, EventArgs e)
        {
       

        }

        private void buttonSeferSil_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand command2 = new SqlCommand("KontrolSeferSil", baglanti);
            command2.CommandType = CommandType.StoredProcedure;
            command2.Parameters.AddWithValue("@SeferNo", SqlDbType.VarChar).Value = textSeferID.Text;

            SqlParameter valueReturn2 = new SqlParameter("@sayacım", SqlDbType.Int);
            valueReturn2.Direction = ParameterDirection.ReturnValue;
            command2.Parameters.Add(valueReturn2);

            command2.ExecuteReader();
            OneOrNUll = (int)command2.Parameters["@sayacım"].Value;


            baglanti.Close();
            if (OneOrNUll==1)

            {
                baglanti.Open();

                SqlCommand SeferSil = new SqlCommand("Delete from seferBilgileri where SeferNo = @seferID", baglanti);
                SeferSil.Parameters.AddWithValue("@seferID",textSeferID.Text);

                SeferSil.ExecuteNonQuery();

                MessageBox.Show("Sefer Silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                baglanti.Close();
            }
            else {

                MessageBox.Show("Böyle bir sefer mevcut değil", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
