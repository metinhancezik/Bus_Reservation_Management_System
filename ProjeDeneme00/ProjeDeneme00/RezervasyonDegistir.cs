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
    public partial class RezervasyonDegistir : Form
    {
        public RezervasyonDegistir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");

        private void RezervasyonDegistir_Load(object sender, EventArgs e)
         {


            SqlDataAdapter dataAdapterr = new SqlDataAdapter("Select * from Sehirler", baglanti);
            DataTable dataTable1 = new DataTable();
            dataAdapterr.Fill(dataTable1);
            textNrdn.ValueMember = "Kod";
            textNrdn.DisplayMember = "SehirIsmi";
            textNrdn.DataSource = dataTable1;


            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Sehirler", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            textNereye2.ValueMember = "Kod";
            textNereye2.DisplayMember = "SehirIsmi";
            textNereye2.DataSource = dataTable;



            grpBoxNerdenNereye.Hide();

        }

        public int OneOrNull;


                public static string GidecekBilgiKltukNo ;
                public static string GidecekBilgiSeferNo;
                public static string GidecekBilgiSeferTarih;
        public int koltukNo;
                 public static string GidecekBilgiSeferNereye;
                 public static string GidecekBilgiSeferNereden;

        private void ButonBul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("Kontrol", baglanti);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TC", SqlDbType.VarChar).Value = textcDegistir.Text;
          
            SqlParameter valueReturn= new SqlParameter("@sayac",SqlDbType.Int);
            valueReturn.Direction= ParameterDirection.ReturnValue;
            command.Parameters.Add(valueReturn);

            command.ExecuteReader();
            OneOrNull =(int)command.Parameters["@sayac"].Value;

           
            baglanti.Close();


            if (OneOrNull==1)
            {
      
             grpBoxNerdenNereye.Show();
              MessageBox.Show("Lütfen Sefer Bilgilerinizi Seçiniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            }
            else
            {
                MessageBox.Show("Üzgünüz Herhangi bir Kaydınız bulunmamaktadır. ","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void groupKoltuk_Enter(object sender, EventArgs e)
        {
           
        }

        private void groupNerdenNereye_Enter(object sender, EventArgs e)
        {
       
        }

        private void buttonSeferBul_Click(object sender, EventArgs e)
        {
           
        }

        private void grpBoxNerdenNereye_Enter(object sender, EventArgs e)
        {
            
        }

        private void buttonSeferBul1_Click(object sender, EventArgs e)
        {
          GidecekBilgiSeferTarih=textNeZmn.Text;
         GidecekBilgiSeferNereye=textNry.Text;
         GidecekBilgiSeferNereden=textNrdn.Text;

        groupKoltuk.Show();
            RDseferGoster SeferGoster=new RDseferGoster();
            SeferGoster.ShowDialog();
        }
        string gelenBilgiTarih = RDseferGoster.GidenBilgiSeferTarihi;
        string gelenBilgiSeferNo=RDseferGoster.GidenBilgiSeferNo;
        
        private void RezervasyonDegistir_Load_1(object sender, EventArgs e)
        {
            grpBoxNerdenNereye.Hide();
            groupKoltuk.Hide();




            SqlDataAdapter dataAdapterr = new SqlDataAdapter("Select * from Sehirler", baglanti);
            DataTable dataTable1 = new DataTable();
            dataAdapterr.Fill(dataTable1);
            textNrdn.ValueMember = "Kod";
            textNrdn.DisplayMember = "SehirIsmi";
            textNrdn.DataSource = dataTable1;


            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Sehirler", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            textNry.ValueMember = "Kod";
            textNry.DisplayMember = "SehirIsmi";
            textNry.DataSource = dataTable;


            baglanti.Close();
        }

        private void textNereden1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNeZaman1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonRez_Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle=new SqlCommand("update rezervasyonYap set koltukNo=@KoltukNo, Tarih=@YeniTarih where YolcuTcNo=@yolcuTC",baglanti);
            guncelle.Parameters.AddWithValue("@KoltukNo", koltukNo.ToString());
            guncelle.Parameters.AddWithValue("@yolcuTC", textcDegistir.Text);
            guncelle.Parameters.AddWithValue("@YeniTarih", GidecekBilgiSeferTarih);
            SqlCommand guncelle2 = new SqlCommand("update  set koltukNo=@KoltukNo where YolcuTcNo=@yolcuTC");

            guncelle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Seferniz Başarıyla Güncellendi!", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
        }

        private void koltuk8_Click(object sender, EventArgs e)
        {
            koltukNo = 8;
        }

        private void koltuk7_Click(object sender, EventArgs e)
        {
            koltukNo = 7;
        }

        private void koltuk6_Click(object sender, EventArgs e)
        {
            koltukNo = 6;
        }

        private void koltuk5_Click(object sender, EventArgs e)
        {
            koltukNo = 5;
        }

        private void koltuk4_Click(object sender, EventArgs e)
        {
            koltukNo = 4;
        } 
        private void button13_Click(object sender, EventArgs e)
        {
            koltukNo = 3;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            koltukNo = 2;
        }


        private void button15_Click(object sender, EventArgs e)
        {
            koltukNo = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int OneOrNull;
            int[] arrayKoltukNo = new int[8];

            koltuk1.BackColor = Color.Green;
            koltuk2.BackColor = Color.Green;
            koltuk3.BackColor = Color.Green;
            koltuk4.BackColor = Color.Green;
            koltuk5.BackColor = Color.Green;
            koltuk6.BackColor = Color.Green;
            koltuk7.BackColor = Color.Green;
            koltuk8.BackColor = Color.Green;



            for (int i = 1; i < 9; i++)
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("koltukVarMi", baglanti);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@KoltukNumarasi", SqlDbType.VarChar).Value = i.ToString();
                command.Parameters.AddWithValue("@SeferNumarasi", SqlDbType.Int).Value = RDseferGoster.GidenBilgiSeferNo;
                SqlParameter valueReturn = new SqlParameter("@sonuc", SqlDbType.Int);
                valueReturn.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(valueReturn);

                command.ExecuteReader();
                OneOrNull = (int)command.Parameters["@sonuc"].Value;
                baglanti.Close();

                if (OneOrNull == 1)
                {
                    arrayKoltukNo[i - 1] = i;

                }
                else
                {

                }


            }







            



            for (int i = 0; i < 8; i++)
            {
                if (arrayKoltukNo[i] == 1)
                {

                    koltuk1.BackColor = Color.Red;
                    koltuk1.Enabled = false;
                }

                else if (arrayKoltukNo[i] == 2)
                {
                    koltuk2.BackColor = System.Drawing.Color.Red;
                    koltuk2.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 3)
                {
                    koltuk3.BackColor = Color.Red;
                    koltuk3.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 4)
                {
                    koltuk4.BackColor = Color.Red;

                    koltuk4.Enabled = false;

                }
                else if (arrayKoltukNo[i] == 5)
                {
                    koltuk5.BackColor = Color.Red;

                    koltuk5.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 6)
                {
                    koltuk6.BackColor = Color.Red;

                    koltuk6.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 7)
                {
                    koltuk7.BackColor = Color.Red;

                    koltuk7.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 8)
                {
                    koltuk8.BackColor = Color.Red;

                    koltuk8.Enabled = false;
                }

            }
        }
    }
}
