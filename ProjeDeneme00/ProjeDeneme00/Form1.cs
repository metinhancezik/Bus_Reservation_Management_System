using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;



namespace ProjeDeneme00
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }

       SqlConnection baglanti= new SqlConnection(@"Data Source=MRGREEN\SQLEXPRESS;Initial Catalog=deneme3;Integrated Security=True;Encrypt=False");
        


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
           
            
         
        }
        
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void baglantiButon_Click(object sender, EventArgs e)
        {

        }

        private void SoforKaydet_Click(object sender, EventArgs e)
        {

        }

       

        private void textTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textRezervasyonTcNo_TextChanged(object sender, EventArgs e)
        {
            
          

            

        }

        private void buttonSeferleriGtr_Click(object sender, EventArgs e)
        {

        }

        private void buttonSoforleriGtr_Click(object sender, EventArgs e)
        {
 
        }

        private void SeferBilgiKaydet_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor=Color.FromArgb(100, 0, 0, 0);
            panelLabel.BackColor = Color.FromArgb(100, 0, 0,0);


            seferIslemi1.Hide();
            yolcuIslemleri1.Hide();
            yorumIslemleri1.Hide();

        }

        private void textSeferNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            panelLabel.Hide();
            seferIslemi1.Hide();
            yolcuIslemleri1.Hide();
            yorumIslemleri1.Show();
            yorumIslemleri1.BringToFront();
        }

        private void buttonRezervasyon_Click(object sender, EventArgs e)
        {
            
            panelLabel.Hide();
            seferIslemi1.Hide();
            yorumIslemleri1.Hide();
            yolcuIslemleri1.Show();
            yolcuIslemleri1.BringToFront();
        }

        private void buttonSefer_Click(object sender, EventArgs e)
        {
           
            panelLabel.Hide();
            yolcuIslemleri1.Hide();
            yorumIslemleri1.Hide();
            seferIslemi1.Show();
            seferIslemi1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            
        }

        private void yolcuIslemleri1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void panelLabel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}