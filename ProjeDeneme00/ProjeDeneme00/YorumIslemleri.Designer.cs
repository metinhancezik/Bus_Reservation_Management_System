namespace ProjeDeneme00
{
    partial class YorumIslemleri
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textYorum = new System.Windows.Forms.RichTextBox();
            this.YolcuYorumKaydet = new System.Windows.Forms.Button();
            this.textYorumSeferID = new System.Windows.Forms.TextBox();
            this.textYorumID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonYorumDegistir = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.textYorum);
            this.groupBox6.Controls.Add(this.YolcuYorumKaydet);
            this.groupBox6.Controls.Add(this.textYorumSeferID);
            this.groupBox6.Controls.Add(this.textYorumID);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox6.Location = new System.Drawing.Point(17, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(389, 381);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Yolcu Yorumları";
            // 
            // textYorum
            // 
            this.textYorum.Location = new System.Drawing.Point(6, 160);
            this.textYorum.Name = "textYorum";
            this.textYorum.Size = new System.Drawing.Size(366, 161);
            this.textYorum.TabIndex = 7;
            this.textYorum.Text = "";
            // 
            // YolcuYorumKaydet
            // 
            this.YolcuYorumKaydet.ForeColor = System.Drawing.Color.Black;
            this.YolcuYorumKaydet.Location = new System.Drawing.Point(282, 338);
            this.YolcuYorumKaydet.Name = "YolcuYorumKaydet";
            this.YolcuYorumKaydet.Size = new System.Drawing.Size(75, 37);
            this.YolcuYorumKaydet.TabIndex = 8;
            this.YolcuYorumKaydet.Text = "Kaydet";
            this.YolcuYorumKaydet.UseVisualStyleBackColor = true;
            this.YolcuYorumKaydet.Click += new System.EventHandler(this.YolcuYorumKaydet_Click);
            // 
            // textYorumSeferID
            // 
            this.textYorumSeferID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textYorumSeferID.Location = new System.Drawing.Point(129, 89);
            this.textYorumSeferID.Name = "textYorumSeferID";
            this.textYorumSeferID.Size = new System.Drawing.Size(243, 26);
            this.textYorumSeferID.TabIndex = 2;
            // 
            // textYorumID
            // 
            this.textYorumID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textYorumID.Location = new System.Drawing.Point(129, 55);
            this.textYorumID.Name = "textYorumID";
            this.textYorumID.Size = new System.Drawing.Size(243, 26);
            this.textYorumID.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 19);
            this.label20.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.Location = new System.Drawing.Point(8, 92);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 19);
            this.label26.TabIndex = 6;
            this.label26.Text = "SeferID";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(8, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 19);
            this.label25.TabIndex = 6;
            this.label25.Text = "TC ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(382, 343);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonYorumDegistir
            // 
            this.buttonYorumDegistir.Location = new System.Drawing.Point(569, 349);
            this.buttonYorumDegistir.Name = "buttonYorumDegistir";
            this.buttonYorumDegistir.Size = new System.Drawing.Size(129, 32);
            this.buttonYorumDegistir.TabIndex = 9;
            this.buttonYorumDegistir.Text = "Yorumu Değiştir";
            this.buttonYorumDegistir.UseVisualStyleBackColor = true;
            this.buttonYorumDegistir.Click += new System.EventHandler(this.buttonYorumDegistir_Click);
            // 
            // YorumIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.buttonYorumDegistir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox6);
            this.DoubleBuffered = true;
            this.Name = "YorumIslemleri";
            this.Size = new System.Drawing.Size(813, 384);
            this.Load += new System.EventHandler(this.YorumIslemleri_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox6;
        private RichTextBox textYorum;
        private Button YolcuYorumKaydet;
        private TextBox textYorumSeferID;
        private TextBox textYorumID;
        private Label label20;
        private Label label26;
        private Label label25;
        private DataGridView dataGridView1;
        private Button buttonYorumDegistir;
    }
}
