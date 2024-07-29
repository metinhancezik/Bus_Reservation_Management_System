namespace ProjeDeneme00
{
    partial class SeferIslemi
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
            this.groupSofor = new System.Windows.Forms.GroupBox();
            this.buttonSoforSil = new System.Windows.Forms.Button();
            this.buttonSoforleriGtr = new System.Windows.Forms.Button();
            this.textKapanTelNO = new System.Windows.Forms.MaskedTextBox();
            this.SoforKaydet = new System.Windows.Forms.Button();
            this.textKaptanSurname = new System.Windows.Forms.TextBox();
            this.textKaptanNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textKaptanName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupSefer = new System.Windows.Forms.GroupBox();
            this.buttonSeferSil = new System.Windows.Forms.Button();
            this.buttonSeferleriGtr = new System.Windows.Forms.Button();
            this.SeferBilgiKaydet = new System.Windows.Forms.Button();
            this.textSeferSaat = new System.Windows.Forms.MaskedTextBox();
            this.textSeferTarih = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textSeferKalkış = new System.Windows.Forms.TextBox();
            this.textSeferFiyat = new System.Windows.Forms.TextBox();
            this.textSeferVarış = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxKaptanlar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupOtobus = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textSeferID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textPlaka = new System.Windows.Forms.MaskedTextBox();
            this.textMarka = new System.Windows.Forms.ComboBox();
            this.groupSofor.SuspendLayout();
            this.groupSefer.SuspendLayout();
            this.groupOtobus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSofor
            // 
            this.groupSofor.BackColor = System.Drawing.Color.Transparent;
            this.groupSofor.Controls.Add(this.buttonSoforSil);
            this.groupSofor.Controls.Add(this.buttonSoforleriGtr);
            this.groupSofor.Controls.Add(this.textKapanTelNO);
            this.groupSofor.Controls.Add(this.SoforKaydet);
            this.groupSofor.Controls.Add(this.textKaptanSurname);
            this.groupSofor.Controls.Add(this.textKaptanNo);
            this.groupSofor.Controls.Add(this.label16);
            this.groupSofor.Controls.Add(this.label17);
            this.groupSofor.Controls.Add(this.label18);
            this.groupSofor.Controls.Add(this.textKaptanName);
            this.groupSofor.Controls.Add(this.label19);
            this.groupSofor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupSofor.ForeColor = System.Drawing.Color.LightCoral;
            this.groupSofor.Location = new System.Drawing.Point(440, 16);
            this.groupSofor.Name = "groupSofor";
            this.groupSofor.Size = new System.Drawing.Size(368, 371);
            this.groupSofor.TabIndex = 11;
            this.groupSofor.TabStop = false;
            this.groupSofor.Text = "Şoför Ekle";
            this.groupSofor.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // buttonSoforSil
            // 
            this.buttonSoforSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSoforSil.Location = new System.Drawing.Point(235, 279);
            this.buttonSoforSil.Name = "buttonSoforSil";
            this.buttonSoforSil.Size = new System.Drawing.Size(97, 28);
            this.buttonSoforSil.TabIndex = 11;
            this.buttonSoforSil.Text = "Şoför Sil";
            this.buttonSoforSil.UseVisualStyleBackColor = true;
            this.buttonSoforSil.Click += new System.EventHandler(this.buttonSoforSil_Click);
            // 
            // buttonSoforleriGtr
            // 
            this.buttonSoforleriGtr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSoforleriGtr.Location = new System.Drawing.Point(113, 279);
            this.buttonSoforleriGtr.Name = "buttonSoforleriGtr";
            this.buttonSoforleriGtr.Size = new System.Drawing.Size(116, 27);
            this.buttonSoforleriGtr.TabIndex = 10;
            this.buttonSoforleriGtr.Text = "Şoförleri Göster";
            this.buttonSoforleriGtr.UseVisualStyleBackColor = true;
            this.buttonSoforleriGtr.Click += new System.EventHandler(this.buttonSoforleriGtr_Click);
            // 
            // textKapanTelNO
            // 
            this.textKapanTelNO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textKapanTelNO.Location = new System.Drawing.Point(153, 176);
            this.textKapanTelNO.Mask = "(999) 000-0000";
            this.textKapanTelNO.Name = "textKapanTelNO";
            this.textKapanTelNO.Size = new System.Drawing.Size(100, 26);
            this.textKapanTelNO.TabIndex = 9;
            // 
            // SoforKaydet
            // 
            this.SoforKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SoforKaydet.Location = new System.Drawing.Point(20, 279);
            this.SoforKaydet.Name = "SoforKaydet";
            this.SoforKaydet.Size = new System.Drawing.Size(87, 27);
            this.SoforKaydet.TabIndex = 8;
            this.SoforKaydet.Text = "Kaydet";
            this.SoforKaydet.UseVisualStyleBackColor = true;
            this.SoforKaydet.Click += new System.EventHandler(this.SoforKaydet_Click);
            // 
            // textKaptanSurname
            // 
            this.textKaptanSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textKaptanSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textKaptanSurname.Location = new System.Drawing.Point(153, 136);
            this.textKaptanSurname.Name = "textKaptanSurname";
            this.textKaptanSurname.Size = new System.Drawing.Size(100, 26);
            this.textKaptanSurname.TabIndex = 1;
            // 
            // textKaptanNo
            // 
            this.textKaptanNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textKaptanNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textKaptanNo.Location = new System.Drawing.Point(153, 57);
            this.textKaptanNo.Name = "textKaptanNo";
            this.textKaptanNo.Size = new System.Drawing.Size(100, 26);
            this.textKaptanNo.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(75, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 19);
            this.label16.TabIndex = 6;
            this.label16.Text = "Soyad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(75, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 19);
            this.label17.TabIndex = 6;
            this.label17.Text = "Kaptan No";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(75, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 19);
            this.label18.TabIndex = 6;
            this.label18.Text = "Telefon";
            // 
            // textKaptanName
            // 
            this.textKaptanName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textKaptanName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textKaptanName.Location = new System.Drawing.Point(153, 96);
            this.textKaptanName.Name = "textKaptanName";
            this.textKaptanName.Size = new System.Drawing.Size(100, 26);
            this.textKaptanName.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(75, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 19);
            this.label19.TabIndex = 6;
            this.label19.Text = "Ad";
            // 
            // groupSefer
            // 
            this.groupSefer.BackColor = System.Drawing.Color.Transparent;
            this.groupSefer.Controls.Add(this.buttonSeferSil);
            this.groupSefer.Controls.Add(this.buttonSeferleriGtr);
            this.groupSefer.Controls.Add(this.SeferBilgiKaydet);
            this.groupSefer.Controls.Add(this.textSeferSaat);
            this.groupSefer.Controls.Add(this.textSeferTarih);
            this.groupSefer.Controls.Add(this.label14);
            this.groupSefer.Controls.Add(this.label13);
            this.groupSefer.Controls.Add(this.textSeferKalkış);
            this.groupSefer.Controls.Add(this.textSeferFiyat);
            this.groupSefer.Controls.Add(this.textSeferVarış);
            this.groupSefer.Controls.Add(this.label12);
            this.groupSefer.Controls.Add(this.comboBoxKaptanlar);
            this.groupSefer.Controls.Add(this.label11);
            this.groupSefer.Controls.Add(this.label15);
            this.groupSefer.Controls.Add(this.label10);
            this.groupSefer.Controls.Add(this.label9);
            this.groupSefer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupSefer.ForeColor = System.Drawing.Color.LightCoral;
            this.groupSefer.Location = new System.Drawing.Point(59, 16);
            this.groupSefer.Name = "groupSefer";
            this.groupSefer.Size = new System.Drawing.Size(366, 371);
            this.groupSefer.TabIndex = 10;
            this.groupSefer.TabStop = false;
            this.groupSefer.Text = "Sefer Ekle";
            // 
            // buttonSeferSil
            // 
            this.buttonSeferSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSeferSil.Location = new System.Drawing.Point(236, 278);
            this.buttonSeferSil.Name = "buttonSeferSil";
            this.buttonSeferSil.Size = new System.Drawing.Size(106, 33);
            this.buttonSeferSil.TabIndex = 11;
            this.buttonSeferSil.Text = "Sefer Sil";
            this.buttonSeferSil.UseVisualStyleBackColor = true;
            this.buttonSeferSil.Click += new System.EventHandler(this.buttonSeferSil_Click);
            // 
            // buttonSeferleriGtr
            // 
            this.buttonSeferleriGtr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSeferleriGtr.Location = new System.Drawing.Point(117, 279);
            this.buttonSeferleriGtr.Name = "buttonSeferleriGtr";
            this.buttonSeferleriGtr.Size = new System.Drawing.Size(113, 30);
            this.buttonSeferleriGtr.TabIndex = 10;
            this.buttonSeferleriGtr.Text = "Seferleri Göster";
            this.buttonSeferleriGtr.UseVisualStyleBackColor = true;
            this.buttonSeferleriGtr.Click += new System.EventHandler(this.buttonSeferleriGtr_Click);
            // 
            // SeferBilgiKaydet
            // 
            this.SeferBilgiKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SeferBilgiKaydet.Location = new System.Drawing.Point(22, 279);
            this.SeferBilgiKaydet.Name = "SeferBilgiKaydet";
            this.SeferBilgiKaydet.Size = new System.Drawing.Size(89, 30);
            this.SeferBilgiKaydet.TabIndex = 8;
            this.SeferBilgiKaydet.Text = "Kaydet";
            this.SeferBilgiKaydet.UseVisualStyleBackColor = true;
            this.SeferBilgiKaydet.Click += new System.EventHandler(this.SeferBilgiKaydet_Click);
            // 
            // textSeferSaat
            // 
            this.textSeferSaat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSeferSaat.Location = new System.Drawing.Point(100, 147);
            this.textSeferSaat.Mask = "00:00";
            this.textSeferSaat.Name = "textSeferSaat";
            this.textSeferSaat.Size = new System.Drawing.Size(100, 26);
            this.textSeferSaat.TabIndex = 9;
            this.textSeferSaat.ValidatingType = typeof(System.DateTime);
            // 
            // textSeferTarih
            // 
            this.textSeferTarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSeferTarih.Location = new System.Drawing.Point(100, 112);
            this.textSeferTarih.Mask = "00/00/0000";
            this.textSeferTarih.Name = "textSeferTarih";
            this.textSeferTarih.Size = new System.Drawing.Size(100, 26);
            this.textSeferTarih.TabIndex = 9;
            this.textSeferTarih.ValidatingType = typeof(System.DateTime);
            this.textSeferTarih.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textSeferTarih_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(26, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Kaptan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(26, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Saat";
            // 
            // textSeferKalkış
            // 
            this.textSeferKalkış.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSeferKalkış.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSeferKalkış.Location = new System.Drawing.Point(100, 33);
            this.textSeferKalkış.Name = "textSeferKalkış";
            this.textSeferKalkış.Size = new System.Drawing.Size(100, 26);
            this.textSeferKalkış.TabIndex = 1;
            this.textSeferKalkış.TextChanged += new System.EventHandler(this.textSeferKalkış_TextChanged);
            // 
            // textSeferFiyat
            // 
            this.textSeferFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSeferFiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSeferFiyat.Location = new System.Drawing.Point(100, 211);
            this.textSeferFiyat.Name = "textSeferFiyat";
            this.textSeferFiyat.Size = new System.Drawing.Size(100, 26);
            this.textSeferFiyat.TabIndex = 2;
            // 
            // textSeferVarış
            // 
            this.textSeferVarış.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSeferVarış.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSeferVarış.Location = new System.Drawing.Point(100, 70);
            this.textSeferVarış.Name = "textSeferVarış";
            this.textSeferVarış.Size = new System.Drawing.Size(100, 26);
            this.textSeferVarış.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 19);
            this.label12.TabIndex = 6;
            // 
            // comboBoxKaptanlar
            // 
            this.comboBoxKaptanlar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxKaptanlar.FormattingEnabled = true;
            this.comboBoxKaptanlar.Location = new System.Drawing.Point(100, 180);
            this.comboBoxKaptanlar.Name = "comboBoxKaptanlar";
            this.comboBoxKaptanlar.Size = new System.Drawing.Size(100, 27);
            this.comboBoxKaptanlar.TabIndex = 5;
            this.comboBoxKaptanlar.SelectedIndexChanged += new System.EventHandler(this.comboBoxKaptanlar_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(22, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tarih";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(26, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Fiyat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(22, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Varış";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(22, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Kalkış";
            // 
            // groupOtobus
            // 
            this.groupOtobus.Controls.Add(this.textMarka);
            this.groupOtobus.Controls.Add(this.label3);
            this.groupOtobus.Controls.Add(this.label2);
            this.groupOtobus.Controls.Add(this.label1);
            this.groupOtobus.Controls.Add(this.textSeferID);
            this.groupOtobus.Controls.Add(this.button1);
            this.groupOtobus.Controls.Add(this.textPlaka);
            this.groupOtobus.ForeColor = System.Drawing.Color.LightCoral;
            this.groupOtobus.Location = new System.Drawing.Point(837, 16);
            this.groupOtobus.Name = "groupOtobus";
            this.groupOtobus.Size = new System.Drawing.Size(277, 371);
            this.groupOtobus.TabIndex = 12;
            this.groupOtobus.TabStop = false;
            this.groupOtobus.Text = "Otobüs Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "SeferID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plaka";
            // 
            // textSeferID
            // 
            this.textSeferID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSeferID.Location = new System.Drawing.Point(106, 170);
            this.textSeferID.Name = "textSeferID";
            this.textSeferID.Size = new System.Drawing.Size(100, 23);
            this.textSeferID.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(106, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sefere Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPlaka
            // 
            this.textPlaka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textPlaka.Location = new System.Drawing.Point(106, 55);
            this.textPlaka.Name = "textPlaka";
            this.textPlaka.Size = new System.Drawing.Size(100, 23);
            this.textPlaka.TabIndex = 0;
            // 
            // textMarka
            // 
            this.textMarka.FormattingEnabled = true;
            this.textMarka.Items.AddRange(new object[] {
            "MERCEDES",
            "NEOPLAN",
            "AKIA ",
            "BMC ",
            "Cobus ",
            "DAF ",
            "Hyundai ",
            "Irizar ",
            "Isuzu "});
            this.textMarka.Location = new System.Drawing.Point(106, 116);
            this.textMarka.Name = "textMarka";
            this.textMarka.Size = new System.Drawing.Size(100, 23);
            this.textMarka.TabIndex = 6;
            // 
            // SeferIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.groupOtobus);
            this.Controls.Add(this.groupSofor);
            this.Controls.Add(this.groupSefer);
            this.DoubleBuffered = true;
            this.Name = "SeferIslemi";
            this.Size = new System.Drawing.Size(1140, 404);
            this.Load += new System.EventHandler(this.SeferIslemi_Load);
            this.groupSofor.ResumeLayout(false);
            this.groupSofor.PerformLayout();
            this.groupSefer.ResumeLayout(false);
            this.groupSefer.PerformLayout();
            this.groupOtobus.ResumeLayout(false);
            this.groupOtobus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupSofor;
        private Button buttonSoforleriGtr;
        private MaskedTextBox textKapanTelNO;
        private Button SoforKaydet;
        private TextBox textKaptanSurname;
        private TextBox textKaptanNo;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textKaptanName;
        private Label label19;
        private GroupBox groupSefer;
        private Button buttonSeferleriGtr;
        private Button SeferBilgiKaydet;
        private MaskedTextBox textSeferSaat;
        private MaskedTextBox textSeferTarih;
        private Label label14;
        private Label label13;
        private TextBox textSeferKalkış;
        private TextBox textSeferFiyat;
        private TextBox textSeferVarış;
        private Label label12;
        private ComboBox comboBoxKaptanlar;
        private Label label11;
        private Label label15;
        private Label label10;
        private Label label9;
        private GroupBox groupOtobus;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textSeferID;
        private Button button1;
        private MaskedTextBox textPlaka;
        private Button buttonSoforSil;
        private Button buttonSeferSil;
        private ComboBox textMarka;
    }
}
