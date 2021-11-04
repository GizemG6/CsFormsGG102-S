using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsFormsGG102_S_Ana.OgreniIsleri.OgrEntity;

namespace CsFormsGG102_S_Ana.OgreniIsleri
{
    public partial class frmBolumGiris : Form
    {
        readonly StudentsEntities sdb = new StudentsEntities();
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
            int i = 0;
            var lst = (from s in sdb.tbl_Departments select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[1].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
    }
}
