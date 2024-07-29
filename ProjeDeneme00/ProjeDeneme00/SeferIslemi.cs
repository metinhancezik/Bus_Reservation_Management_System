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
    public partial class SeferIslemi : UserControl
    {
        public SeferIslemi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");
        private void SeferIslemi_Load(object sender, EventArgs e)
        {
            this.BackColor= Color.FromArgb(100, 0, 0, 0);
            baglanti.Open();
            SqlDataAdapter dataAdapterr = new SqlDataAdapter("Select * from soforBilgileri", baglanti);
            DataTable dataTable1 = new DataTable();
            dataAdapterr.Fill(dataTable1);
            comboBoxKaptanlar.ValueMember = "KaptanNo";
            comboBoxKaptanlar.DisplayMember = "SoforAdi";


            comboBoxKaptanlar.DataSource = dataTable1;
            baglanti.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void SoforKaydet_Click(object sender, EventArgs e)
        {
            try
            {


                baglanti.Open();

                SqlCommand command = new SqlCommand("insert into soforBilgileri (KaptanNo,SoforAdi,SoforSoyadi,SoforTelefonNo)values(@kaptanBilgi1,@kaptanBilgi2,@kaptanBilgi3,@kaptanBilgi4)", baglanti);

                command.Parameters.AddWithValue("@kaptanBilgi1", textKaptanNo.Text);
                command.Parameters.AddWithValue("@kaptanBilgi2", textKaptanName.Text);
                command.Parameters.AddWithValue("@kaptanBilgi3", textKaptanSurname.Text);
                command.Parameters.AddWithValue("@kaptanBilgi4", textKapanTelNO.Text);


                command.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kaptan Bilgileri Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("ID başka birine ait!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void SeferBilgiKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand command = new SqlCommand("insert into  seferBilgileri (SeferKalkis,SeferVaris,SeferTarih,SeferSaat,SeferFiyat,KaptanNo)values(@seferBilgi2,@seferBilgi3,@seferBilgi4,@seferBilgi5,@seferBilgi6,@seferBilgi7)", baglanti);

            // command.Parameters.AddWithValue("@seferBilgi1", textSeferNo.Text);
            command.Parameters.AddWithValue("@seferBilgi2", textSeferKalkış.Text);
            command.Parameters.AddWithValue("@seferBilgi3", textSeferVarış.Text);
            command.Parameters.AddWithValue("@seferBilgi4", textSeferTarih.Text);
            command.Parameters.AddWithValue("@seferBilgi5", textSeferSaat.Text);
            command.Parameters.AddWithValue("@seferBilgi6", textSeferFiyat.Text);
            command.Parameters.AddWithValue("@seferBilgi7", comboBoxKaptanlar.Text);
            command.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Sefer Bilgileri Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSoforleriGtr_Click(object sender, EventArgs e)
        {
            SoforGoster f3 = new SoforGoster();
            f3.ShowDialog();
        }

        private void buttonSeferleriGtr_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void textSeferTarih_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBoxKaptanlar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();

                SqlCommand command = new SqlCommand("insert into  Otobus (Plaka,Marka,SeferID)values(@otobus1,@otobus2,@otobus3)", baglanti);


                command.Parameters.AddWithValue("@otobus1", textPlaka.Text);
                command.Parameters.AddWithValue("@otobus2", textMarka.Text);
                command.Parameters.AddWithValue("@otobus3", textSeferID.Text);

                command.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Otobüs Sefere Kaydedildi!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch { 
            
            MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                baglanti.Close();
            }

        }

   
        private void textSeferKalkış_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSoforSil_Click(object sender, EventArgs e)
        {
            SoforSil sl = new SoforSil();
            sl.ShowDialog();

        }

        private void buttonSeferSil_Click(object sender, EventArgs e)
        {
            SeferSil ss = new SeferSil();
            ss.ShowDialog();
        }
    }
}
