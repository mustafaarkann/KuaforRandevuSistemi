using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUAFÖR_RANDEVU_SİSTEMİ.Class
{


    public class Randevu : Müşteri,IHizmetvePersonel
    {
        frmRandevuEkle frmRandevu=new frmRandevuEkle();
        public Randevu(string Müşteriad, string Müşterisoyad, string Müşteritelno,DateTime Randevutarih,string Randevusaat) : base(Müşteriad, Müşterisoyad, Müşteritelno)
        {
            Randevusaat = frmRandevu.maskedTextBoxRandevuEklSaat.Text;
        }

        public void RandevuEkleEkle(object sender, EventArgs e)
        {

            string MüsteriAd = frmRandevu.txtRandevuEkleAd.Text.Trim();
            string MüsteriSoyad = frmRandevu.txtRandevuEkleSoyad.Text;
            string MüsteriTelno = frmRandevu.maskedTextBoxRandevuEkleTelNo.Text;
            string randevuSaat = frmRandevu.maskedTextBoxRandevuEklSaat.Text;
            string randevuTarih = frmRandevu.dateTimePickerRandevuEkle.Text;
            string Hizmet = frmRandevu.comboBoxRandevuEkleHizmet.SelectedItem.ToString();
            string Personel = frmRandevu.comboBoxRandevuEklePersonel.SelectedItem.ToString();

            if (string.IsNullOrEmpty(MüsteriAd))
            {
                MessageBox.Show("Lütfen bir Ad girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrEmpty(MüsteriSoyad))
            {
                MessageBox.Show("Lütfen bir Soy Ad girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            if (string.IsNullOrWhiteSpace(MüsteriTelno) || !frmRandevu.maskedTextBoxRandevuEkleTelNo.MaskFull)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParseExact(randevuSaat, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime result))
            {

                MessageBox.Show("Lütfen geçerli bir saat formatı girin (HH:MM).", "Geçersiz Format");
            }

            if (frmRandevu.comboBoxRandevuEkleHizmet.SelectedIndex == -1)
            {

                MessageBox.Show("Lütfen bir Hizmet seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (frmRandevu.comboBoxRandevuEklePersonel.SelectedIndex == -1)
            {

                MessageBox.Show("Lütfen bir Personel seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string dosyaAdresi = @"C:\Users\User\source\repos\KUAFÖR_RANDEVU_SİSTEMİ\MüsteriRandevuBilgileri.txt";

            using (StreamWriter stryaz = new StreamWriter(dosyaAdresi, true)) // İkinci parametre "true", dosyanın sonuna ekleme anlamına gelir
            {
                stryaz.WriteLine(MüsteriAd + "/" + MüsteriSoyad + "/" + MüsteriTelno + "/" + randevuTarih + "/" + randevuSaat + "/" + Personel + "/" + Hizmet);
            }

            

            string dosyaYolu = @"C:\\Users\\User\\source\\repos\\KUAFÖR_RANDEVU_SİSTEMİ\MüsteriRandevuBilgileri.txt";
        }
    }
}
