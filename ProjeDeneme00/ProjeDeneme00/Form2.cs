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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");
        void seferListesiniGetir()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapterr = new SqlDataAdapter("Select * from seferBilgileri", baglanti);
            DataTable dataTable1 = new DataTable();
            dataAdapterr.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
            baglanti.Close();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            seferListesiniGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
