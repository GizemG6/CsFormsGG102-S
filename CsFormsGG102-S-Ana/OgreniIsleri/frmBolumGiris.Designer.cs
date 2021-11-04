
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scBolumler)).BeginInit();
            this.scBolumler.Panel2.SuspendLayout();
            this.scBolumler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // scBolumler.Panel2
            // 
            this.scBolumler.Panel2.Controls.Add(this.dataGridView1);
            this.scBolumler.Size = new System.Drawing.Size(463, 417);
            this.scBolumler.SplitterDistance = 194;
            this.scBolumler.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmBolumGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 417);
            this.Controls.Add(this.scBolumler);
            this.Name = "frmBolumGiris";
            this.Text = "frmBolumGiris";
            this.scBolumler.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBolumler)).EndInit();
            this.scBolumler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scBolumler;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}