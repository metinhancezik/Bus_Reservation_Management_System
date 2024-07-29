namespace ProjeDeneme00
{
    partial class YolcuIslemleri
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textRezervasyonDate = new System.Windows.Forms.MaskedTextBox();
            this.rezervasyonGoster = new System.Windows.Forms.Button();
            this.RezervasyonSil = new System.Windows.Forms.Button();
            this.rezervasyonDegis = new System.Windows.Forms.Button();
            this.textRezervasyonTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RezervasyonKaydet = new System.Windows.Forms.Button();
            this.textRezervasyonTcNo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textRezervasyonKoltukNo = new System.Windows.Forms.TextBox();
            this.textRezervasyonSeferNo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textTc = new System.Windows.Forms.MaskedTextBox();
            this.textNo = new System.Windows.Forms.MaskedTextBox();
            this.YolcuBilgiKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textCinsiyet = new System.Windows.Forms.ComboBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonKltkGoster = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Koltukno1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSeferBul = new System.Windows.Forms.Button();
            this.textNeZaman = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNereye = new System.Windows.Forms.ComboBox();
            this.textNereden = new System.Windows.Forms.ComboBox();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.textRezervasyonDate);
            this.groupBox5.Controls.Add(this.rezervasyonGoster);
            this.groupBox5.Controls.Add(this.RezervasyonSil);
            this.groupBox5.Controls.Add(this.rezervasyonDegis);
            this.groupBox5.Controls.Add(this.textRezervasyonTelefonNo);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.RezervasyonKaydet);
            this.groupBox5.Controls.Add(this.textRezervasyonTcNo);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.textRezervasyonKoltukNo);
            this.groupBox5.Controls.Add(this.textRezervasyonSeferNo);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox5.Location = new System.Drawing.Point(903, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(377, 327);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rezervasyon Yap";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // textRezervasyonDate
            // 
            this.textRezervasyonDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textRezervasyonDate.Location = new System.Drawing.Point(90, 269);
            this.textRezervasyonDate.Mask = "00/00/0000";
            this.textRezervasyonDate.Name = "textRezervasyonDate";
            this.textRezervasyonDate.Size = new System.Drawing.Size(100, 22);
            this.textRezervasyonDate.TabIndex = 13;
            this.textRezervasyonDate.ValidatingType = typeof(System.DateTime);
            this.textRezervasyonDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textRezervasyonDate_MaskInputRejected);
            this.textRezervasyonDate.TextChanged += new System.EventHandler(this.textRezervasyonDate_TextChanged);
            // 
            // rezervasyonGoster
            // 
            this.rezervasyonGoster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rezervasyonGoster.Location = new System.Drawing.Point(225, 241);
            this.rezervasyonGoster.Name = "rezervasyonGoster";
            this.rezervasyonGoster.Size = new System.Drawing.Size(140, 40);
            this.rezervasyonGoster.TabIndex = 12;
            this.rezervasyonGoster.Text = "Rezervasyonu Göster";
            this.rezervasyonGoster.UseVisualStyleBackColor = true;
            this.rezervasyonGoster.Click += new System.EventHandler(this.rezervasyonGoster_Click);
            // 
            // RezervasyonSil
            // 
            this.RezervasyonSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RezervasyonSil.Location = new System.Drawing.Point(225, 187);
            this.RezervasyonSil.Name = "RezervasyonSil";
            this.RezervasyonSil.Size = new System.Drawing.Size(140, 27);
            this.RezervasyonSil.TabIndex = 11;
            this.RezervasyonSil.Text = "Rezervasyonu Sil";
            this.RezervasyonSil.UseVisualStyleBackColor = true;
            this.RezervasyonSil.Click += new System.EventHandler(this.RezervasyonSil_Click);
            // 
            // rezervasyonDegis
            // 
            this.rezervasyonDegis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rezervasyonDegis.Location = new System.Drawing.Point(225, 113);
            this.rezervasyonDegis.Name = "rezervasyonDegis";
            this.rezervasyonDegis.Size = new System.Drawing.Size(140, 46);
            this.rezervasyonDegis.TabIndex = 10;
            this.rezervasyonDegis.Text = "Rezervasyon Değiştir";
            this.rezervasyonDegis.UseVisualStyleBackColor = true;
            this.rezervasyonDegis.Click += new System.EventHandler(this.rezervasyonDegis_Click);
            // 
            // textRezervasyonTelefonNo
            // 
            this.textRezervasyonTelefonNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textRezervasyonTelefonNo.Location = new System.Drawing.Point(90, 175);
            this.textRezervasyonTelefonNo.Mask = "(999) 000-0000";
            this.textRezervasyonTelefonNo.Name = "textRezervasyonTelefonNo";
            this.textRezervasyonTelefonNo.Size = new System.Drawing.Size(100, 22);
            this.textRezervasyonTelefonNo.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(24, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tarih";
            // 
            // RezervasyonKaydet
            // 
            this.RezervasyonKaydet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RezervasyonKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RezervasyonKaydet.Location = new System.Drawing.Point(225, 63);
            this.RezervasyonKaydet.Name = "RezervasyonKaydet";
            this.RezervasyonKaydet.Size = new System.Drawing.Size(140, 27);
            this.RezervasyonKaydet.TabIndex = 8;
            this.RezervasyonKaydet.Text = "Rezervasyon Yap";
            this.RezervasyonKaydet.UseVisualStyleBackColor = true;
            this.RezervasyonKaydet.Click += new System.EventHandler(this.RezervasyonKaydet_Click);
            // 
            // textRezervasyonTcNo
            // 
            this.textRezervasyonTcNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRezervasyonTcNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textRezervasyonTcNo.Location = new System.Drawing.Point(90, 124);
            this.textRezervasyonTcNo.Name = "textRezervasyonTcNo";
            this.textRezervasyonTcNo.Size = new System.Drawing.Size(100, 22);
            this.textRezervasyonTcNo.TabIndex = 2;
            this.textRezervasyonTcNo.TextChanged += new System.EventHandler(this.textRezervasyonTcNo_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(9, 229);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 19);
            this.label28.TabIndex = 6;
            this.label28.Text = "Koltuk No";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(12, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 19);
            this.label21.TabIndex = 6;
            this.label21.Text = "Sefer No";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(12, 178);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 19);
            this.label23.TabIndex = 6;
            this.label23.Text = "Telefon";
            // 
            // textRezervasyonKoltukNo
            // 
            this.textRezervasyonKoltukNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRezervasyonKoltukNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textRezervasyonKoltukNo.Location = new System.Drawing.Point(90, 227);
            this.textRezervasyonKoltukNo.Name = "textRezervasyonKoltukNo";
            this.textRezervasyonKoltukNo.Size = new System.Drawing.Size(100, 22);
            this.textRezervasyonKoltukNo.TabIndex = 0;
            this.textRezervasyonKoltukNo.TextChanged += new System.EventHandler(this.textRezervasyonKoltukNo_TextChanged);
            // 
            // textRezervasyonSeferNo
            // 
            this.textRezervasyonSeferNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRezervasyonSeferNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textRezervasyonSeferNo.Location = new System.Drawing.Point(90, 73);
            this.textRezervasyonSeferNo.Name = "textRezervasyonSeferNo";
            this.textRezervasyonSeferNo.Size = new System.Drawing.Size(100, 22);
            this.textRezervasyonSeferNo.TabIndex = 0;
            this.textRezervasyonSeferNo.TextChanged += new System.EventHandler(this.textRezervasyonSeferNo_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(14, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 19);
            this.label22.TabIndex = 6;
            this.label22.Text = "TC No";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textTc);
            this.groupBox2.Controls.Add(this.textNo);
            this.groupBox2.Controls.Add(this.YolcuBilgiKaydet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textAd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.textCinsiyet);
            this.groupBox2.Controls.Add(this.textMail);
            this.groupBox2.Controls.Add(this.textSoyad);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Location = new System.Drawing.Point(586, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 327);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yolcu Bilgileri";
            // 
            // textTc
            // 
            this.textTc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textTc.Location = new System.Drawing.Point(124, 107);
            this.textTc.Mask = "00000000000";
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(100, 26);
            this.textTc.TabIndex = 9;
            // 
            // textNo
            // 
            this.textNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNo.Location = new System.Drawing.Point(124, 149);
            this.textNo.Mask = "(999) 000-0000";
            this.textNo.Name = "textNo";
            this.textNo.Size = new System.Drawing.Size(100, 26);
            this.textNo.TabIndex = 9;
            // 
            // YolcuBilgiKaydet
            // 
            this.YolcuBilgiKaydet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YolcuBilgiKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YolcuBilgiKaydet.Location = new System.Drawing.Point(90, 283);
            this.YolcuBilgiKaydet.Name = "YolcuBilgiKaydet";
            this.YolcuBilgiKaydet.Size = new System.Drawing.Size(87, 29);
            this.YolcuBilgiKaydet.TabIndex = 8;
            this.YolcuBilgiKaydet.Text = "Kaydet";
            this.YolcuBilgiKaydet.UseVisualStyleBackColor = true;
            this.YolcuBilgiKaydet.Click += new System.EventHandler(this.YolcuBilgiKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(52, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(46, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(46, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(46, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(46, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "TC No";
            // 
            // textAd
            // 
            this.textAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textAd.Location = new System.Drawing.Point(124, 26);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(100, 26);
            this.textAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(46, 73);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(48, 19);
            this.label29.TabIndex = 6;
            this.label29.Text = "Soyad";
            // 
            // textCinsiyet
            // 
            this.textCinsiyet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCinsiyet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textCinsiyet.FormattingEnabled = true;
            this.textCinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.textCinsiyet.Location = new System.Drawing.Point(124, 237);
            this.textCinsiyet.Name = "textCinsiyet";
            this.textCinsiyet.Size = new System.Drawing.Size(100, 27);
            this.textCinsiyet.TabIndex = 5;
            this.textCinsiyet.SelectedIndexChanged += new System.EventHandler(this.textCinsiyet_SelectedIndexChanged);
            // 
            // textMail
            // 
            this.textMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textMail.Location = new System.Drawing.Point(124, 188);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(100, 26);
            this.textMail.TabIndex = 4;
            // 
            // textSoyad
            // 
            this.textSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSoyad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSoyad.Location = new System.Drawing.Point(124, 70);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(100, 26);
            this.textSoyad.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonKltkGoster);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Koltukno1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(310, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 327);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koltuk Seç";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonKltkGoster
            // 
            this.buttonKltkGoster.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonKltkGoster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKltkGoster.Location = new System.Drawing.Point(36, 287);
            this.buttonKltkGoster.Name = "buttonKltkGoster";
            this.buttonKltkGoster.Size = new System.Drawing.Size(157, 23);
            this.buttonKltkGoster.TabIndex = 8;
            this.buttonKltkGoster.Text = "Dolu Koltukları Göster";
            this.buttonKltkGoster.UseVisualStyleBackColor = true;
            this.buttonKltkGoster.Click += new System.EventHandler(this.buttonKltkGoster_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(118, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 52);
            this.button8.TabIndex = 7;
            this.button8.Text = "Koltuk no: 8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(21, 229);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 52);
            this.button7.TabIndex = 6;
            this.button7.Text = "Koltuk no: 7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(118, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 52);
            this.button6.TabIndex = 5;
            this.button6.Text = "Koltuk no: 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(21, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "Koltuk no: 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(118, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Koltuk no: 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(21, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Koltuk no: 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(118, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Koltuk no: 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Koltukno1
            // 
            this.Koltukno1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Koltukno1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Koltukno1.Location = new System.Drawing.Point(21, 44);
            this.Koltukno1.Name = "Koltukno1";
            this.Koltukno1.Size = new System.Drawing.Size(81, 52);
            this.Koltukno1.TabIndex = 0;
            this.Koltukno1.Text = "Koltuk no: 1";
            this.Koltukno1.UseVisualStyleBackColor = true;
            this.Koltukno1.Click += new System.EventHandler(this.Koltukno1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSeferBul);
            this.groupBox3.Controls.Add(this.textNeZaman);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textNereye);
            this.groupBox3.Controls.Add(this.textNereden);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox3.Location = new System.Drawing.Point(28, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 327);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sefer Bul";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonSeferBul
            // 
            this.buttonSeferBul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSeferBul.Location = new System.Drawing.Point(60, 216);
            this.buttonSeferBul.Name = "buttonSeferBul";
            this.buttonSeferBul.Size = new System.Drawing.Size(110, 38);
            this.buttonSeferBul.TabIndex = 6;
            this.buttonSeferBul.Text = "Seferleri Bul";
            this.buttonSeferBul.UseVisualStyleBackColor = true;
            this.buttonSeferBul.Click += new System.EventHandler(this.buttonSeferBul_Click);
            // 
            // textNeZaman
            // 
            this.textNeZaman.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNeZaman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNeZaman.Location = new System.Drawing.Point(110, 165);
            this.textNeZaman.Mask = "00/00/0000";
            this.textNeZaman.Name = "textNeZaman";
            this.textNeZaman.Size = new System.Drawing.Size(100, 26);
            this.textNeZaman.TabIndex = 9;
            this.textNeZaman.ValidatingType = typeof(System.DateTime);
            this.textNeZaman.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textNeZaman_MaskInputRejected);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(44, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(40, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nereye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nereden";
            // 
            // textNereye
            // 
            this.textNereye.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNereye.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNereye.FormattingEnabled = true;
            this.textNereye.Location = new System.Drawing.Point(110, 112);
            this.textNereye.Name = "textNereye";
            this.textNereye.Size = new System.Drawing.Size(100, 27);
            this.textNereye.TabIndex = 5;
            this.textNereye.SelectedIndexChanged += new System.EventHandler(this.textNereye_SelectedIndexChanged);
            // 
            // textNereden
            // 
            this.textNereden.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNereden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNereden.FormattingEnabled = true;
            this.textNereden.Location = new System.Drawing.Point(110, 55);
            this.textNereden.Name = "textNereden";
            this.textNereden.Size = new System.Drawing.Size(100, 27);
            this.textNereden.TabIndex = 5;
            this.textNereden.SelectedIndexChanged += new System.EventHandler(this.textNereden_SelectedIndexChanged);
            // 
            // YolcuIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "YolcuIslemleri";
            this.Size = new System.Drawing.Size(1301, 382);
            this.Load += new System.EventHandler(this.YolcuIslemleri_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox5;
        private MaskedTextBox textRezervasyonTelefonNo;
        private Button RezervasyonKaydet;
        private TextBox textRezervasyonTcNo;
        private Label label28;
        private Label label21;
        private Label label23;
        private TextBox textRezervasyonKoltukNo;
        private Label label22;
        private GroupBox groupBox2;
        private MaskedTextBox textTc;
        private MaskedTextBox textNo;
        private Button YolcuBilgiKaydet;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textAd;
        private Label label1;
        private Label label29;
        private ComboBox textCinsiyet;
        private TextBox textMail;
        private TextBox textSoyad;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button buttonSeferBul;
        private Label label8;
        private Label label2;
        private ComboBox textNereye;
        private ComboBox textNereden;
        private Label label9;
        private MaskedTextBox textNeZaman;
        private Label label10;
        private Button rezervasyonDegis;
        private Button rezervasyonGoster;
        private Button RezervasyonSil;
        public TextBox textRezervasyonSeferNo;
        public Button button8;
        public Button button7;
        public Button button6;
        public Button button5;
        public Button button4;
        public Button button3;
        public Button button2;
        public Button Koltukno1;
        public MaskedTextBox textRezervasyonDate;
        private Button buttonKltkGoster;
    }
}
