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
    public partial class frmUrunFiyat : Form
    {
        public frmUrunFiyat()
        {
            InitializeComponent();
        }

        private void frmUrunFiyat_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            textBox1.Text=KDVHesapla(int.Parse(textBox2.Text),int.Parse(textBox3.Text)).ToString();
            
        }

         static float KDVHesapla(int fiyat,int oran)
        {
            fiyat = Convert.ToInt32(Console.ReadLine());
            oran = Convert.ToInt32(Console.ReadLine());
            float kdvdeger = fiyat + (fiyat * oran / 100);
            return kdvdeger;
        }
    }
}
