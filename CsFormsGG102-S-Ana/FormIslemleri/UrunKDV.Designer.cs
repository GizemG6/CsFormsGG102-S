
namespace CsFormsGG102_S_Ana.FormIslemleri
{
    partial class UrunKDV
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
            this.btnSorgula1 = new System.Windows.Forms.Button();
            this.txtadi1 = new System.Windows.Forms.TextBox();
            this.txtfiyat1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSorgula1
            // 
            this.btnSorgula1.Location = new System.Drawing.Point(90, 204);
            this.btnSorgula1.Name = "btnSorgula1";
            this.btnSorgula1.Size = new System.Drawing.Size(145, 59);
            this.btnSorgula1.TabIndex = 0;
            this.btnSorgula1.Text = "Sorgula";
            this.btnSorgula1.UseVisualStyleBackColor = true;
            this.btnSorgula1.Click += new System.EventHandler(this.btnSorgula1_Click);
            // 
            // txtadi1
            // 
            this.txtadi1.Location = new System.Drawing.Point(181, 67);
            this.txtadi1.Name = "txtadi1";
            this.txtadi1.Size = new System.Drawing.Size(100, 20);
            this.txtadi1.TabIndex = 1;
            // 
            // txtfiyat1
            // 
            this.txtfiyat1.Location = new System.Drawing.Point(181, 104);
            this.txtfiyat1.Name = "txtfiyat1";
            this.txtfiyat1.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat1.TabIndex = 2;
            // 
            // UrunKDV
            // 
            this.ClientSize = new System.Drawing.Size(349, 323);
            this.Controls.Add(this.txtfiyat1);
            this.Controls.Add(this.txtadi1);
            this.Controls.Add(this.btnSorgula1);
            this.Name = "UrunKDV";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txtfiyati;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSorgula1;
        private System.Windows.Forms.TextBox txtadi1;
        private System.Windows.Forms.TextBox txtfiyat1;
    }
}