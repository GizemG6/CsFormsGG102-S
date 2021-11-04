
namespace CsFormsGG102_S_Ana.OgreniIsleri
{
    partial class frmBolumGiris
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
            this.scBolumler = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scBolumler)).BeginInit();
            this.scBolumler.Panel1.SuspendLayout();
            this.scBolumler.Panel2.SuspendLayout();
            this.scBolumler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // scBolumler
            // 
            this.scBolumler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scBolumler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBolumler.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scBolumler.Location = new System.Drawing.Point(0, 0);
            this.scBolumler.Name = "scBolumler";
            this.scBolumler.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBolumler.Panel1
            // 
            this.scBolumler.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.scBolumler.Panel1.Controls.Add(this.btnKaydet);
            this.scBolumler.Panel1.Controls.Add(this.textBox1);
            this.scBolumler.Panel1.Controls.Add(this.label1);
            // 
            // scBolumler.Panel2
            // 
            this.scBolumler.Panel2.Controls.Add(this.Liste);
            this.scBolumler.Size = new System.Drawing.Size(452, 417);
            this.scBolumler.SplitterDistance = 155;
            this.scBolumler.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BolumAdi});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(448, 254);
            this.Liste.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Sira No";
            this.Id.Name = "Id";
            this.Id.Width = 67;
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BolumAdi.HeaderText = "Bolum";
            this.BolumAdi.Name = "BolumAdi";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bolum Adi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(334, 61);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 48);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kayit";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // frmBolumGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 417);
            this.Controls.Add(this.scBolumler);
            this.Name = "frmBolumGiris";
            this.Text = "frmBolumGiris";
            this.Load += new System.EventHandler(this.frmBolumGiris_Load);
            this.scBolumler.Panel1.ResumeLayout(false);
            this.scBolumler.Panel1.PerformLayout();
            this.scBolumler.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBolumler)).EndInit();
            this.scBolumler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scBolumler;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
    }
}