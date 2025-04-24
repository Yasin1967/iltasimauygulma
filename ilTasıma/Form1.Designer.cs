namespace IlAdiTasima
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtIlAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSagaTasi = new System.Windows.Forms.Button();
            this.btnSolaTasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 260);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(300, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 260);
            this.listBox2.TabIndex = 1;
            // 
            // txtIlAdi
            // 
            this.txtIlAdi.Location = new System.Drawing.Point(12, 290);
            this.txtIlAdi.Name = "txtIlAdi";
            this.txtIlAdi.Size = new System.Drawing.Size(200, 22);
            this.txtIlAdi.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(218, 290);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSagaTasi
            // 
            this.btnSagaTasi.Location = new System.Drawing.Point(218, 100);
            this.btnSagaTasi.Name = "btnSagaTasi";
            this.btnSagaTasi.Size = new System.Drawing.Size(75, 23);
            this.btnSagaTasi.TabIndex = 4;
            this.btnSagaTasi.Text = ">>";
            this.btnSagaTasi.UseVisualStyleBackColor = true;
            this.btnSagaTasi.Click += new System.EventHandler(this.btnSagaTasi_Click);
            // 
            // btnSolaTasi
            // 
            this.btnSolaTasi.Location = new System.Drawing.Point(218, 150);
            this.btnSolaTasi.Name = "btnSolaTasi";
            this.btnSolaTasi.Size = new System.Drawing.Size(75, 23);
            this.btnSolaTasi.TabIndex = 5;
            this.btnSolaTasi.Text = "<<";
            this.btnSolaTasi.UseVisualStyleBackColor = true;
            this.btnSolaTasi.Click += new System.EventHandler(this.btnSolaTasi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 333);
            this.Controls.Add(this.btnSolaTasi);
            this.Controls.Add(this.btnSagaTasi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIlAdi);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "İl Adı Taşıma Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtIlAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSagaTasi;
        private System.Windows.Forms.Button btnSolaTasi;
    }
}