namespace ProjeDeneme00
{
    partial class SoforSil
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
            this.buttonKaptanSil = new System.Windows.Forms.Button();
            this.textkaptanNOsil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKaptanSil
            // 
            this.buttonKaptanSil.Location = new System.Drawing.Point(329, 257);
            this.buttonKaptanSil.Name = "buttonKaptanSil";
            this.buttonKaptanSil.Size = new System.Drawing.Size(75, 23);
            this.buttonKaptanSil.TabIndex = 0;
            this.buttonKaptanSil.Text = "Şoförü Sil";
            this.buttonKaptanSil.UseVisualStyleBackColor = true;
            this.buttonKaptanSil.Click += new System.EventHandler(this.buttonKaptanSil_Click);
            // 
            // textkaptanNOsil
            // 
            this.textkaptanNOsil.Location = new System.Drawing.Point(329, 104);
            this.textkaptanNOsil.Name = "textkaptanNOsil";
            this.textkaptanNOsil.Size = new System.Drawing.Size(100, 23);
            this.textkaptanNOsil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kaptan No";
            // 
            // SoforSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textkaptanNOsil);
            this.Controls.Add(this.buttonKaptanSil);
            this.Name = "SoforSil";
            this.Text = "SoforSil";
            this.Load += new System.EventHandler(this.SoforSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonKaptanSil;
        private TextBox textkaptanNOsil;
        private Label label1;
    }
}