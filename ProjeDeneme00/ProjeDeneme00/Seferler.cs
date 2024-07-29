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
    public partial class Seferler : Form
    {
        public Seferler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");


        public static string GidenBilgi1;

        public static string GidenBilgi2;

        string GelenBilgi1 = YolcuIslemleri.GidenBilgi3;
        string GelenBilgi2 = YolcuIslemleri.GidenBilgi4;
        string GelenBilgi3 = YolcuIslemleri.GidenBilgi5;

        private void Seferler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("SeferBul", baglanti);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@kalkis", SqlDbType.VarChar).Value = GelenBilgi1;
            command.Parameters.AddWithValue("@varis", SqlDbType.VarChar).Value = GelenBilgi2;
            command.Parameters.AddWithValue("@tarih", SqlDbType.VarChar).Value = GelenBilgi3;
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dataGridView1.CurrentRow.Selected = true;

                GidenBilgi1 = dataGridView1.Rows[e.RowIndex].Cells["SeferNo"].FormattedValue.ToString();
                GidenBilgi2 = dataGridView1.Rows[e.RowIndex].Cells["SeferTarih"].FormattedValue.ToString();

            }
        }
        public static int tıklandı = 0;
        private void buttonSec_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Sefer Seçildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            /*

             int OneOrNull;
             int[] arrayKoltukNo = new int[10];




                 for (int i = 1; i < 9; i++)
                 {
                     baglanti.Open();
                     SqlCommand command = new SqlCommand("koltukVarMi", baglanti);
                     command.CommandType = CommandType.StoredProcedure;
                     command.Parameters.AddWithValue("@KoltukNumarasi", SqlDbType.VarChar).Value = i.ToString();
                     command.Parameters.AddWithValue("@SeferNumarasi", SqlDbType.Int).Value = GidenBilgi1;
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
                 YolcuIslemleri YI = new YolcuIslemleri();

             

                         YI.textRezervasyonDate.Text = GidenBilgi2;
                         YI.textRezervasyonSeferNo.Text = GidenBilgi1;

                
            YI.seferDateVeTarih();
           


            for (int i = 0; i < 8; i++)
                {
                    if (arrayKoltukNo[i] == 1)
                    {
                       
                    YI.Koltukno1.BackColor = Color.Red;
                    YI.Koltukno1.Enabled = false;
                }

                    else if (arrayKoltukNo[i] == 2)
                    {
                    YI.button2.BackColor = System.Drawing.Color.Red;
                    YI.button2.Enabled = false;
                }
                    else if (arrayKoltukNo[i] == 3)
                    {
                      YI.button3.BackColor = Color.Red;
                      YI.button3.Enabled = false;
                }
                    else if (arrayKoltukNo[i] == 4)
                    {
                    YI.button4.BackColor =Color.Red;
                    
                    YI.button4.Enabled = false;
                 
                }
                    else if (arrayKoltukNo[i] == 5)
                    {
                    YI.button5.BackColor = Color.Red;

                    YI.button5.Enabled = false;
                }
                    else if (arrayKoltukNo[i] == 6)
                    {
                    YI.button6.BackColor = Color.Red;

                    YI.button6.Enabled = false;
                }
                    else if (arrayKoltukNo[i] == 7)
                    {
                    YI.button7.BackColor = Color.Red;

                    YI.button7.Enabled = false;
                }
                    else if (arrayKoltukNo[i] == 8)
                    {
                    YI.button8.BackColor = Color.Red;

                    YI.button8.Enabled = false;
                }
                   
                }

            */

                this.Hide();


        }
        }
    }

