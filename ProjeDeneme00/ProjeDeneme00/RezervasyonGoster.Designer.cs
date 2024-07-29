namespace ProjeDeneme00
{
    partial class RezervasyonGoster
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
            this.textcGoster = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButonBulGoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textcGoster
            // 
            this.textcGoster.Location = new System.Drawing.Point(290, 52);
            this.textcGoster.Name = "textcGoster";
            this.textcGoster.Size = new System.Drawing.Size(100, 23);
            this.textcGoster.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "TC";
            // 
            // ButonBulGoster
            // 
            this.ButonBulGoster.Location = new System.Drawing.Point(441, 51);
            this.ButonBulGoster.Name = "ButonBulGoster";
            this.ButonBulGoster.Size = new System.Drawing.Size(75, 23);
            this.ButonBulGoster.TabIndex = 23;
            this.ButonBulGoster.Text = "BUL";
            this.ButonBulGoster.UseVisualStyleBackColor = true;
            this.ButonBulGoster.Click += new System.EventHandler(this.ButonBulGoster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(725, 296);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RezervasyonGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textcGoster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButonBulGoster);
            this.Name = "RezervasyonGoster";
            this.Text = "RezervasyonGoster";
            this.Load += new System.EventHandler(this.RezervasyonGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox textcGoster;
        private Label label3;
        private Button ButonBulGoster;
        private DataGridView dataGridView1;
    }
}