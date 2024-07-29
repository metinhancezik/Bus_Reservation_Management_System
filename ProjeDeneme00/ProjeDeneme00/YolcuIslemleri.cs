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
    public partial class YolcuIslemleri : UserControl
    {
        public static YolcuIslemleri instance;
        public TextBox tbl1;
        public MaskedTextBox tbl2;
        public YolcuIslemleri()
        {
            InitializeComponent();
            instance = this;
            tbl1 = textRezervasyonSeferNo;
            tbl2 = textRezervasyonDate;
            textRezervasyonDate.TextChanged += new EventHandler(textRezervasyonDate_TextChanged);
            textRezervasyonSeferNo.TextChanged += new EventHandler(textRezervasyonSeferNo_TextChanged);


        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");

        /*
   
        public void koltukNumarası2()
        {
            button2.BackColor = Color.Red;
            button2.Enabled = true;
        }

     

        public void koltukNumarası5()
        {
            button5.BackColor = Color.Red;
            button5.Enabled = true;
        }
        public void koltukNumarası6()
        {
            button6.BackColor = Color.Red;
            button6.Enabled = true;
        }
        public void koltukNumarası7()
        {
            button7.BackColor = Color.Red;
            button7.Enabled = true;
        }
        public void koltukNumarası8()
        {
            
            button8.BackColor = Color.Red;
            button8.Enabled = true;
        }
        */
        private void YolcuIslemleri_Load(object sender, EventArgs e)
        {
            textRezervasyonDate.ReadOnly = true;
            textRezervasyonSeferNo.ReadOnly=true;
            textRezervasyonTcNo.ReadOnly = true;
            textRezervasyonTelefonNo.ReadOnly = true;

            this.BackColor= Color.FromArgb(100, 0, 0, 0);


            SqlDataAdapter dataAdapterr = new SqlDataAdapter("Select * from Sehirler", baglanti);
            DataTable dataTable1 = new DataTable();
            dataAdapterr.Fill(dataTable1);
            textNereden.ValueMember = "Kod";
            textNereden.DisplayMember = "SehirIsmi";
            textNereden.DataSource = dataTable1;


            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Sehirler", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            textNereye.ValueMember = "Kod";
            textNereye.DisplayMember = "SehirIsmi";
            textNereye.DataSource = dataTable;



            textRezervasyonSeferNo.Text = Seferler.GidenBilgi1;

            textRezervasyonDate.Text = Seferler.GidenBilgi2;


            }

        
        public static string GidenBilgi3;

        public static string GidenBilgi4;
       
        public static string GidenBilgi5;

        private void YolcuBilgiKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into yolcubilgileri(Yolcuadi ,Yolcusoyadi,YolcuTcNo ,YolcuTelefon,YolcuMail,YolcuCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            cmd.Parameters.AddWithValue("@p1", textAd.Text);
            cmd.Parameters.AddWithValue("@p2", textSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", textTc.Text);
            cmd.Parameters.AddWithValue("@p4", textNo.Text);
            cmd.Parameters.AddWithValue("@p5", textMail.Text);
            cmd.Parameters.AddWithValue("@p6", textCinsiyet.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Bilgileri Sisteme Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textRezervasyonTcNo.Text = textTc.Text;

            textRezervasyonTelefonNo.Text = textNo.Text;
        }


        public void button2_Click_1(object sender, EventArgs e)
       {
            textRezervasyonKoltukNo.Text = "2";
            textRezervasyonKoltukNo.ReadOnly = true;
        }

        public void textRezervasyonTcNo_TextChanged(object sender, EventArgs e)
        {

        }

        public void textRezervasyonKoltukNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void Koltukno1_Click(object sender, EventArgs e)
        {
            
            textRezervasyonKoltukNo.Text = "1";
            textRezervasyonKoltukNo.ReadOnly = true;

   

        }

        public void button3_Click(object sender, EventArgs e)
        {
            textRezervasyonKoltukNo.Text = "3";
            textRezervasyonKoltukNo.ReadOnly = true;


    
        }

        public void button4_Click(object sender, EventArgs e)
        {
            textRezervasyonKoltukNo.Text = "4";
            textRezervasyonKoltukNo.ReadOnly = true;


        }

        public void button5_Click(object sender, EventArgs e)
        {
            textRezervasyonKoltukNo.Text = "5";
            textRezervasyonKoltukNo.ReadOnly = true;
        }

        public void button6_Click(object sender, EventArgs e)
        {
            textRezervasyonKoltukNo.Text = "6";
            textRezervasyonKoltukNo.ReadOnly = true;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            textRezervasyonKoltukNo.Text = "7";
            textRezervasyonKoltukNo.ReadOnly = true;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            textRezervasyonKoltukNo.Text = "8";
            textRezervasyonKoltukNo.ReadOnly = true;
        }

        private void RezervasyonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into rezervasyonYap(SeferNo,YolcuTcNo ,YolcuTelefon,koltukNo,Tarih) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            cmd.Parameters.AddWithValue("@p1", textRezervasyonSeferNo.Text);
            cmd.Parameters.AddWithValue("@p2", textRezervasyonTcNo.Text);
            cmd.Parameters.AddWithValue("@p3", textRezervasyonTelefonNo.Text);
            cmd.Parameters.AddWithValue("@p4", textRezervasyonKoltukNo.Text);
            cmd.Parameters.AddWithValue("@p5", textNeZaman.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Bilgileri Sisteme Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void textRezervasyonSeferNo_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void rezervasyonDegis_Click(object sender, EventArgs e)
        {
            RezervasyonDegistir RD = new RezervasyonDegistir();
            RD.ShowDialog();
        }

        private void RezervasyonSil_Click(object sender, EventArgs e)
        {
            RezervasyonSilme RS = new RezervasyonSilme();
            RS.ShowDialog();
        }

        private void rezervasyonGoster_Click(object sender, EventArgs e)
        {
            RezervasyonGoster RG=new RezervasyonGoster();  
            RG.ShowDialog();
        }
        
        public void seferDateVeTarih()
        {
     
           textRezervasyonSeferNo.Text = Seferler.GidenBilgi1;
           textRezervasyonDate.Text = Seferler.GidenBilgi2;

        }
        private void buttonSeferBul_Click(object sender, EventArgs e)
        {

            GidenBilgi3 = textNereden.Text;
            GidenBilgi4 = textNereye.Text;
            GidenBilgi5 = textNeZaman.Text;

            Seferler YolcuyaSefer= new Seferler();
            YolcuyaSefer.ShowDialog();
        }

        private void textCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void extYolcuDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textNereden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textRezervasyonDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
  
        }

        private void textNereye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textNeZaman_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void textRezervasyonDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonKoltukGoster_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonKltkGoster_Click(object sender, EventArgs e)
        {
            Koltukno1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;

            textRezervasyonDate.Text = Seferler.GidenBilgi2;
            textRezervasyonSeferNo.Text = Seferler.GidenBilgi1;

            int OneOrNull;
            int[] arrayKoltukNo = new int[8];




            for (int i = 1; i < 9; i++)
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("koltukVarMi", baglanti);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@KoltukNumarasi", SqlDbType.VarChar).Value = i.ToString();
                command.Parameters.AddWithValue("@SeferNumarasi", SqlDbType.Int).Value = textRezervasyonSeferNo.Text;
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
            

            



               
            seferDateVeTarih();



            for (int i = 0; i < 8; i++)
            {
                if (arrayKoltukNo[i] == 1)
                {

                    Koltukno1.BackColor = Color.Red;
                    Koltukno1.Enabled = false;
                }

                else if (arrayKoltukNo[i] == 2)
                {
                    button2.BackColor = System.Drawing.Color.Red;
                    button2.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 3)
                {
                    button3.BackColor = Color.Red;
                    button3.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 4)
                {
                    button4.BackColor = Color.Red;

                    button4.Enabled = false;

                }
                else if (arrayKoltukNo[i] == 5)
                {
                    button5.BackColor = Color.Red;

                    button5.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 6)
                {
                    button6.BackColor = Color.Red;

                    button6.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 7)
                {
                    button7.BackColor = Color.Red;

                    button7.Enabled = false;
                }
                else if (arrayKoltukNo[i] == 8)
                {
                    button8.BackColor = Color.Red;

                    button8.Enabled = false;
                }

            }
        }
    }
}
