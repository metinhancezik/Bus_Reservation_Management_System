namespace ProjeDeneme00
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.buttonRezervasyon = new System.Windows.Forms.Button();
            this.buttonSefer = new System.Windows.Forms.Button();
            this.buttonYorum = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.yolcuIslemleri1 = new ProjeDeneme00.YolcuIslemleri();
            this.yorumIslemleri1 = new ProjeDeneme00.YorumIslemleri();
            this.seferIslemi1 = new ProjeDeneme00.SeferIslemi();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.DimGray;
            this.ımageList1.Images.SetKeyName(0, "theater-g4754f3063_1280.png");
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(1049, 17);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(170, 23);
            this.Time.TabIndex = 0;
            // 
            // buttonRezervasyon
            // 
            this.buttonRezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.buttonRezervasyon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRezervasyon.ForeColor = System.Drawing.Color.Tomato;
            this.buttonRezervasyon.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonRezervasyon.ImageKey = "theater-g4754f3063_1280.png";
            this.buttonRezervasyon.ImageList = this.ımageList1;
            this.buttonRezervasyon.Location = new System.Drawing.Point(136, 12);
            this.buttonRezervasyon.Name = "buttonRezervasyon";
            this.buttonRezervasyon.Size = new System.Drawing.Size(214, 47);
            this.buttonRezervasyon.TabIndex = 1;
            this.buttonRezervasyon.Text = "Rezervasyon Oluştur";
            this.buttonRezervasyon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRezervasyon.UseVisualStyleBackColor = false;
            this.buttonRezervasyon.Click += new System.EventHandler(this.buttonRezervasyon_Click);
            // 
            // buttonSefer
            // 
            this.buttonSefer.BackColor = System.Drawing.Color.Transparent;
            this.buttonSefer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSefer.ForeColor = System.Drawing.Color.Tomato;
            this.buttonSefer.Location = new System.Drawing.Point(461, 17);
            this.buttonSefer.Name = "buttonSefer";
            this.buttonSefer.Size = new System.Drawing.Size(128, 36);
            this.buttonSefer.TabIndex = 1;
            this.buttonSefer.Text = "Sefer Oluştur";
            this.buttonSefer.UseVisualStyleBackColor = false;
            this.buttonSefer.Click += new System.EventHandler(this.buttonSefer_Click);
            // 
            // buttonYorum
            // 
            this.buttonYorum.BackColor = System.Drawing.Color.Transparent;
            this.buttonYorum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonYorum.ForeColor = System.Drawing.Color.Tomato;
            this.buttonYorum.Location = new System.Drawing.Point(732, 17);
            this.buttonYorum.Name = "buttonYorum";
            this.buttonYorum.Size = new System.Drawing.Size(128, 36);
            this.buttonYorum.TabIndex = 1;
            this.buttonYorum.Text = "Yorumlar";
            this.buttonYorum.UseVisualStyleBackColor = false;
            this.buttonYorum.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.buttonYorum);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.buttonSefer);
            this.panel1.Controls.Add(this.buttonRezervasyon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 73);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "icon-gea67b1b17_1280.png");
            // 
            // yolcuIslemleri1
            // 
            this.yolcuIslemleri1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yolcuIslemleri1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yolcuIslemleri1.Location = new System.Drawing.Point(25, 157);
            this.yolcuIslemleri1.Name = "yolcuIslemleri1";
            this.yolcuIslemleri1.Size = new System.Drawing.Size(1280, 382);
            this.yolcuIslemleri1.TabIndex = 3;
            // 
            // yorumIslemleri1
            // 
            this.yorumIslemleri1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yorumIslemleri1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yorumIslemleri1.Location = new System.Drawing.Point(259, 122);
            this.yorumIslemleri1.Name = "yorumIslemleri1";
            this.yorumIslemleri1.Size = new System.Drawing.Size(813, 384);
            this.yorumIslemleri1.TabIndex = 5;
            // 
            // seferIslemi1
            // 
            this.seferIslemi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seferIslemi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.seferIslemi1.Location = new System.Drawing.Point(110, 111);
            this.seferIslemi1.Name = "seferIslemi1";
            this.seferIslemi1.Size = new System.Drawing.Size(1140, 404);
            this.seferIslemi1.TabIndex = 7;
            // 
            // panelLabel
            // 
            this.panelLabel.BackColor = System.Drawing.Color.Transparent;
            this.panelLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLabel.Controls.Add(this.label2);
            this.panelLabel.Controls.Add(this.label1);
            this.panelLabel.Location = new System.Drawing.Point(12, 91);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(1293, 628);
            this.panelLabel.TabIndex = 8;
            this.panelLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLabel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(528, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "KGTÜ Turizm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(369, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 138);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bizi Tercih Ettiğiniz İçin\r\n     Teşekkür Ederiz\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 717);
            this.Controls.Add(this.panelLabel);
            this.Controls.Add(this.seferIslemi1);
            this.Controls.Add(this.yorumIslemleri1);
            this.Controls.Add(this.yolcuIslemleri1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public ImageList ımageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private EventHandler form1;

        public EventHandler GetForm1()
        {
            return form1;
        }

        private void SetForm1(EventHandler value)
        {
            form1 = value;
        }
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private DateTimePicker Time;
        private Button buttonRezervasyon;
        private Button buttonSefer;
        private Button buttonYorum;
        private Panel panel1;
        private YolcuIslemleri yolcuIslemleri1;
        private YorumIslemleri yorumIslemleri1;
        private SeferIslemi seferIslemi1;
        private Panel panelLabel;
        private Label label1;
        private Label label2;
        private ImageList ımageList2;
    }
}