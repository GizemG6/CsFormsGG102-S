
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTamSil = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.rbPasif = new System.Windows.Forms.RadioButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.scBolumler.Panel1.Controls.Add(this.rbPasif);
            this.scBolumler.Panel1.Controls.Add(this.rbAktif);
            this.scBolumler.Panel1.Controls.Add(this.rbHepsi);
            this.scBolumler.Panel1.Controls.Add(this.checkBox1);
            this.scBolumler.Panel1.Controls.Add(this.btnTamSil);
            this.scBolumler.Panel1.Controls.Add(this.btnSil);
            this.scBolumler.Panel1.Controls.Add(this.btnTemizle);
            this.scBolumler.Panel1.Controls.Add(this.btnKaydet);
            this.scBolumler.Panel1.Controls.Add(this.txtBolumAdi);
            this.scBolumler.Panel1.Controls.Add(this.label1);
            // 
            // scBolumler.Panel2
            // 
            this.scBolumler.Panel2.Controls.Add(this.Liste);
            this.scBolumler.Size = new System.Drawing.Size(452, 417);
            this.scBolumler.SplitterDistance = 155;
            this.scBolumler.TabIndex = 0;
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
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBolumAdi.Location = new System.Drawing.Point(0, 21);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(448, 20);
            this.txtBolumAdi.TabIndex = 1;
            this.txtBolumAdi.TextChanged += new System.EventHandler(this.txtBolumAdi_TextChanged);
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
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BolumAdi,
            this.isActive});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(448, 254);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(26, 97);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(108, 32);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(153, 97);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 31);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTamSil
            // 
            this.btnTamSil.Location = new System.Drawing.Point(245, 103);
            this.btnTamSil.Name = "btnTamSil";
            this.btnTamSil.Size = new System.Drawing.Size(75, 23);
            this.btnTamSil.TabIndex = 5;
            this.btnTamSil.Text = "Tam Silme";
            this.btnTamSil.UseVisualStyleBackColor = true;
            this.btnTamSil.Click += new System.EventHandler(this.btnTamSil_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(258, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Pasif";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbHepsi
            // 
            this.rbHepsi.Checked = true;
            this.rbHepsi.Location = new System.Drawing.Point(26, 47);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(104, 24);
            this.rbHepsi.TabIndex = 7;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            this.rbHepsi.CheckedChanged += new System.EventHandler(this.rbHepsi_CheckedChanged);
            // 
            // rbAktif
            // 
            this.rbAktif.Location = new System.Drawing.Point(117, 60);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(85, 17);
            this.rbAktif.TabIndex = 8;
            this.rbAktif.Text = "Aktifler";
            this.rbAktif.UseVisualStyleBackColor = true;
            this.rbAktif.CheckedChanged += new System.EventHandler(this.rbAktif_CheckedChanged);
            // 
            // rbPasif
            // 
            this.rbPasif.Location = new System.Drawing.Point(26, 78);
            this.rbPasif.Name = "rbPasif";
            this.rbPasif.Size = new System.Drawing.Size(85, 17);
            this.rbPasif.TabIndex = 9;
            this.rbPasif.Text = "Pasifler";
            this.rbPasif.UseVisualStyleBackColor = true;
            this.rbPasif.CheckedChanged += new System.EventHandler(this.rbPasif_CheckedChanged);
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
            // isActive
            // 
            this.isActive.HeaderText = "Durum";
            this.isActive.Name = "isActive";
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
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTamSil;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbPasif;
        private System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
    }
}