using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsFormsGG102_S_Ana.Fonksiyonlar;
using CsFormsGG102_S_Ana.OgreniIsleri.OgrEntity;

namespace CsFormsGG102_S_Ana.OgreniIsleri
{
    public partial class frmBolumGiris : Form
    {
        readonly StudentsEntities sdb = new StudentsEntities();
        Mesajlar m = new Mesajlar();

        private int secimId = -1;
        private bool edit = false;
        public frmBolumGiris()
        {
            InitializeComponent();
        }

        private void frmBolumGiris_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            if (rbHepsi.Checked==true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tbl_Departments select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
                //Liste.AllowUserToDeleteRows = false;
                //Liste.AllowUserToOrderColumns = false;
            }
            else if (rbAktif.Checked == true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tbl_Departments where s.isActive == true select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
            }
            else if (rbPasif.Checked == true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tbl_Departments where s.isActive == false select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
            }
          
        }
        private void YeniKayit()
        {
            try
            {
                if (txtBolumAdi.Text != "")
                {
                    tbl_Departments blm = new tbl_Departments();
                    blm.BolumAdi = txtBolumAdi.Text;
                    blm.isActive = true;
                    sdb.tbl_Departments.Add(blm);
                    sdb.SaveChanges();
                    m.YeniKayit("Yeni kayit olusturuldu.");
                    // MessageBox.Show("Yeni kayit olusturuldu.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e);
            }
        }
        private void Guncelle()
        {
            try
            {
                //tbl_Departments blm = sdb.tbl_Departments.First(x => x.Id == secimId);
                tbl_Departments blm = sdb.tbl_Departments.Find(secimId);
                //blm.BolumAdi = txtBolumAdi.Text;
                blm.Id = 22222;  //Hata alabilmek icin
                sdb.SaveChanges();
                m.Guncelle(true);
            }
            catch (Exception e)
            {

                m.Guncelle(false);
                m.Guncelle(e);
                MessageBox.Show("" + e);
                Close();
            }
            //MessageBox.Show("Kayit guncellestirildi.");
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(secimId>0 && edit == true && m.Guncelle()==DialogResult.Yes)
            {
                Guncelle();
            }
            else if(edit==false)
            {
                YeniKayit();
            }
            //else
            //{
            //    Temizle();
            //}
            Listele();
            Temizle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int)Liste.CurrentRow.Cells[0].Value;
            txtBolumAdi.Text= Liste.CurrentRow.Cells[1].Value.ToString();

            if (secimId > 0) edit = true;

           // MessageBox.Show(secimId.ToString());
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            secimId = -1;
            edit = false;
            txtBolumAdi.Clear();
        }

        private void txtBolumAdi_TextChanged(object sender, EventArgs e)
        {
            //if (txtBolumAdi.Text == "")
            //{
            //    edit = false;
            //}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            Temizle();
            Listele();
        }
        private void Sil()
        {
            try
            {
                tbl_Departments blm = sdb.tbl_Departments.Find(secimId);
                blm.isActive = false;
                sdb.SaveChanges();
                m.Sil("Kayit silindi");
                //MessageBox.Show("Kayit silinmistir.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e);
            }
        }

        private void btnTamSil_Click(object sender, EventArgs e)
        {
            sdb.tbl_Departments.Remove(sdb.tbl_Departments.Find(secimId));
            sdb.SaveChanges();

            Temizle();
            Listele();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tbl_Departments where s.isActive == false select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
            }
            else
            {
                Listele();
            }
        }

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void rbPasif_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
