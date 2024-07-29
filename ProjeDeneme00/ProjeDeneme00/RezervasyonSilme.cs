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
    public partial class RezervasyonSilme : Form
    {
        public RezervasyonSilme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");
        public int OneOrNUll, OneOrNUll2;
        private void RezervasyonSilme_Load(object sender, EventArgs e)
        {
     


        }

        private void ButonBulSilme_Click(object sender, EventArgs e)
        {


            baglanti.Open();

            SqlCommand command2 = new SqlCommand("KontrolSeferID", baglanti);
            command2.CommandType = CommandType.StoredProcedure;
            command2.Parameters.AddWithValue("@SeferNo", SqlDbType.VarChar).Value = textSeferID1.Text;
            command2.Parameters.AddWithValue("@TC", SqlDbType.VarChar).Value = textcSilme.Text;
            SqlParameter valueReturn2 = new SqlParameter("@sayac2", SqlDbType.Int);
            valueReturn2.Direction = ParameterDirection.ReturnValue;
            command2.Parameters.Add(valueReturn2);

            command2.ExecuteReader();
            OneOrNUll2 = (int)command2.Parameters["@sayac2"].Value;
            baglanti.Close();


            

           

            if (OneOrNUll2 == 1)
            {


                DialogResult dialogResult = MessageBox.Show("Seferiniz Bulundu. Silmek İstediğinize Emin Misiniz? !", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand delete = new SqlCommand("delete from rezervasyonYap where YolcuTcNo = @yolcuTC and SeferNo=@seferID", baglanti);
                    delete.Parameters.AddWithValue("@yolcuTC", textcSilme.Text);
                    delete.Parameters.AddWithValue("@seferID", textSeferID1.Text);
                    delete.ExecuteNonQuery();

                    MessageBox.Show("Seferiniz Sildi", "Bilgilendirme",MessageBoxButtons.OK);
                   
                }
                else
                {
                    MessageBox.Show("Talebiniz Üzerine Herhangi bir işlem yapılmadı.", "Bilgilendirme", MessageBoxButtons.OK);
                    
                }

            }

            else if (OneOrNUll2 == 0)
            {
                MessageBox.Show("Üzgünüz Herhangi bir Kaydınız bulunmamaktadır. ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
   
            baglanti.Close();
        }
    }
}
