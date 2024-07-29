namespace ProjeDeneme00
{
    partial class RezervasyonSilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textcSilme = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButonBulSilme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSeferID1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textcSilme
            // 
            this.textcSilme.Location = new System.Drawing.Point(249, 44);
            this.textcSilme.Name = "textcSilme";
            this.textcSilme.Size = new System.Drawing.Size(100, 23);
            this.textcSilme.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "TC";
            // 
            // ButonBulSilme
            // 
            this.ButonBulSilme.Location = new System.Drawing.Point(403, 63);
            this.ButonBulSilme.Name = "ButonBulSilme";
            this.ButonBulSilme.Size = new System.Drawing.Size(75, 23);
            this.ButonBulSilme.TabIndex = 23;
            this.ButonBulSilme.Text = "Bul ve Sil";
            this.ButonBulSilme.UseVisualStyleBackColor = true;
            this.ButonBulSilme.Click += new System.EventHandler(this.ButonBulSilme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "SeferID";
            // 
            // textSeferID1
            // 
            this.textSeferID1.Location = new System.Drawing.Point(249, 92);
            this.textSeferID1.Name = "textSeferID1";
            this.textSeferID1.Size = new System.Drawing.Size(100, 23);
            this.textSeferID1.TabIndex = 25;
            // 
            // RezervasyonSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSeferID1);
            this.Controls.Add(this.textcSilme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButonBulSilme);
            this.Name = "RezervasyonSilme";
            this.Text = "RezervasyonSilme";
            this.Load += new System.EventHandler(this.RezervasyonSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox textcSilme;
        private Label label3;
        private Button ButonBulSilme;
        private Label label1;
        private MaskedTextBox textSeferID1;
    }
}