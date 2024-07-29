namespace ProjeDeneme00
{
    partial class YorumDegis
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
            this.textGuncelYorum = new System.Windows.Forms.RichTextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textGuncelYorum
            // 
            this.textGuncelYorum.Location = new System.Drawing.Point(37, 55);
            this.textGuncelYorum.Name = "textGuncelYorum";
            this.textGuncelYorum.Size = new System.Drawing.Size(721, 173);
            this.textGuncelYorum.TabIndex = 0;
            this.textGuncelYorum.Text = "";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(683, 284);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 1;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // YorumDegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textGuncelYorum);
            this.Name = "YorumDegis";
            this.Text = "YorumDegis";
            this.Load += new System.EventHandler(this.YorumDegis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textGuncelYorum;
        private Button buttonKaydet;
    }
}