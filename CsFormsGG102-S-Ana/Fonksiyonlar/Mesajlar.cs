using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsFormsGG102_S_Ana.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj,"Yeni Kayit Giris",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Secili olan kayit güncellenecektir\nGüncelleme islemini onayliyor musunuz?", "Güncelleme Islemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncelle(bool guncelleme)
        {
            if (guncelleme==true)
            {
                MessageBox.Show("Kayit guncellenmistir", "Kayit Guncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Kayit guncellenemedi", "Kayit Guncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Guncelle(Exception e)
        {
            MessageBox.Show(""+e, "Kayit Guncelleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Sil(string mesaj)
        {
            MessageBox.Show(mesaj, "Kayit silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
