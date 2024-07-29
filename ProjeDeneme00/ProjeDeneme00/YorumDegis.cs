using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeDeneme00
{
    public partial class YorumDegis : Form
    {
        public YorumDegis()
        {
            InitializeComponent();
        }
        public static string  GidenGuncelYorum;
        private void YorumDegis_Load(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            GidenGuncelYorum= textGuncelYorum.Text;

            MessageBox.Show("Yorum Güncellendi!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
