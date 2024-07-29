namespace ProjeDeneme00
{
    partial class SeferSil
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
            this.buttonSeferSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSeferID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSeferSil
            // 
            this.buttonSeferSil.Location = new System.Drawing.Point(333, 269);
            this.buttonSeferSil.Name = "buttonSeferSil";
            this.buttonSeferSil.Size = new System.Drawing.Size(75, 23);
            this.buttonSeferSil.TabIndex = 0;
            this.buttonSeferSil.Text = "Sefer Sil";
            this.buttonSeferSil.UseVisualStyleBackColor = true;
            this.buttonSeferSil.Click += new System.EventHandler(this.buttonSeferSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "SeferID";
            // 
            // textSeferID
            // 
            this.textSeferID.Location = new System.Drawing.Point(333, 129);
            this.textSeferID.Name = "textSeferID";
            this.textSeferID.Size = new System.Drawing.Size(100, 23);
            this.textSeferID.TabIndex = 2;
            // 
            // SeferSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textSeferID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSeferSil);
            this.Name = "SeferSil";
            this.Text = "SeferSil";
            this.Load += new System.EventHandler(this.SeferSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSeferSil;
        private Label label1;
        private TextBox textSeferID;
    }
}