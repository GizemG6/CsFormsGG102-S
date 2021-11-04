
namespace CsFormsGG102_S_Ana.FormIslemleri
{
    partial class UrunFiyatKDVHesabi
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
            this.txtKDVadi = new System.Windows.Forms.TextBox();
            this.txtKDVfiyati = new System.Windows.Forms.TextBox();
            this.txtSonKDV = new System.Windows.Forms.TextBox();
            this.txtSonFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKDVadi
            // 
            this.txtKDVadi.Location = new System.Drawing.Point(254, 44);
            this.txtKDVadi.Name = "txtKDVadi";
            this.txtKDVadi.Size = new System.Drawing.Size(100, 20);
            this.txtKDVadi.TabIndex = 0;
            // 
            // txtKDVfiyati
            // 
            this.txtKDVfiyati.Location = new System.Drawing.Point(254, 104);
            this.txtKDVfiyati.Name = "txtKDVfiyati";
            this.txtKDVfiyati.Size = new System.Drawing.Size(100, 20);
            this.txtKDVfiyati.TabIndex = 1;
            // 
            // txtSonKDV
            // 
            this.txtSonKDV.Location = new System.Drawing.Point(254, 160);
            this.txtSonKDV.Name = "txtSonKDV";
            this.txtSonKDV.Size = new System.Drawing.Size(100, 20);
            this.txtSonKDV.TabIndex = 2;
            // 
            // txtSonFiyat
            // 
            this.txtSonFiyat.Location = new System.Drawing.Point(254, 215);
            this.txtSonFiyat.Name = "txtSonFiyat";
            this.txtSonFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtSonFiyat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Urun Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(119, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Urun Fiyati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(119, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "KDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(119, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "KDVli Fiyat";
            // 
            // UrunFiyatKDVHesabi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 332);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSonFiyat);
            this.Controls.Add(this.txtSonKDV);
            this.Controls.Add(this.txtKDVfiyati);
            this.Controls.Add(this.txtKDVadi);
            this.Name = "UrunFiyatKDVHesabi";
            this.Text = "UrunFiyat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtKDVadi;
        public System.Windows.Forms.TextBox txtKDVfiyati;
        public System.Windows.Forms.TextBox txtSonKDV;
        public System.Windows.Forms.TextBox txtSonFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}