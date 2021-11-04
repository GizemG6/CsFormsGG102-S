using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsFormsGG102_S_Ana.FormIslemleri
{
    public partial class UrunKDV : Form
    {
        public UrunKDV()
        {
            InitializeComponent();
        }

       /*/ private void btnSorgula_Click(object sender, EventArgs e)
        {
            UrunFiyatKDVHesabi frm = new UrunFiyatKDVHesabi();
            frm.txtKDVadi.Text = txtadi.Text;
            frm.txtKDVfiyati.Text = txtfiyati.Text;
            frm.txtSonKDV.Text = "1,18";
            double kdvlifiyat = 0;
            kdvlifiyat = double.Parse(txtfiyati.Text) * double.Parse(frm.txtSonKDV.Text);
            frm.txtSonFiyat.Text = kdvlifiyat.ToString();

            frm.Show();
        }/*/

        private void btnSorgula1_Click(object sender, EventArgs e)
        {
            UrunFiyatKDVHesabi frm = new UrunFiyatKDVHesabi();
            frm.txtKDVadi.Text = txtadi1.Text;
            frm.txtKDVfiyati.Text = txtfiyat1.Text;
            frm.txtSonKDV.Text = "1,18";
            double kdvlifiyat = 0;
            kdvlifiyat = double.Parse(txtfiyat1.Text) * double.Parse(frm.txtSonKDV.Text);
            frm.txtSonFiyat.Text = kdvlifiyat.ToString();

            frm.Show();
        }
    }
}
