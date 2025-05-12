using KUAFÖR_RANDEVU_SİSTEMİ.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KUAFÖR_RANDEVU_SİSTEMİ
{
    public partial class frmRandevuEkle : Form
    {
        public frmRandevuEkle()
        {
            InitializeComponent();
            dateTimePickerRandevuEkle.MinDate = DateTime.Now.Date;
            dateTimePickerRandevuEkle.Format = DateTimePickerFormat.Short; // "Short" tarih formatını kullanır (örn. 10/05/2024)
            //LoadDataFromTxt();
        }

        private void RandevuEkle_Load(object sender, EventArgs e)
        {
            UpdateCheckedListBox();
        }

        private void btnRandevuEkleGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain main = new FrmMain();
            main.ShowDialog();
        }

        public void btnRandevuEkleEkle_Click(object sender, EventArgs e)
        {

            string MüsteriAd = txtRandevuEkleAd.Text.Trim();
            string MüsteriSoyad = txtRandevuEkleSoyad.Text;
            string MüsteriTelno = maskedTextBoxRandevuEkleTelNo.Text;
            string randevuSaat = maskedTextBoxRandevuEklSaat.Text;
            string randevuTarih = dateTimePickerRandevuEkle.Text;
            string Hizmet = comboBoxRandevuEkleHizmet.SelectedItem.ToString();
            string Personel = comboBoxRandevuEklePersonel.SelectedItem.ToString();

            if (string.IsNullOrEmpty(MüsteriAd))
            {
                MessageBox.Show("Lütfen bir Ad girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrEmpty(MüsteriSoyad))
            {
                MessageBox.Show("Lütfen bir Soy Ad girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            if (string.IsNullOrWhiteSpace(MüsteriTelno) || !maskedTextBoxRandevuEkleTelNo.MaskFull)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParseExact(randevuSaat, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime result))
            {

                MessageBox.Show("Lütfen geçerli bir saat formatı girin (HH:MM).", "Geçersiz Format");
            }

            if (comboBoxRandevuEkleHizmet.SelectedIndex == -1)
            {

                MessageBox.Show("Lütfen bir Hizmet seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (comboBoxRandevuEklePersonel.SelectedIndex == -1)
            {

                MessageBox.Show("Lütfen bir Personel seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string dosyaAdresi = @"C:\Users\User\source\repos\KUAFÖR_RANDEVU_SİSTEMİ\MüsteriRandevuBilgileri.txt";

            using (StreamWriter stryaz = new StreamWriter(dosyaAdresi, true)) // İkinci parametre "true", dosyanın sonuna ekleme anlamına gelir
            {
                stryaz.WriteLine(MüsteriAd + "/" + MüsteriSoyad + "/" + MüsteriTelno + "/" + randevuTarih + "/" + randevuSaat + "/" + Personel + "/" + Hizmet);
            }

            UpdateCheckedListBox();

            string dosyaYolu = @"C:\\Users\\User\\source\\repos\\KUAFÖR_RANDEVU_SİSTEMİ\MüsteriRandevuBilgileri.txt";
        }

        private void UpdateCheckedListBox()
        {
            string dosyaYolu = @"C:\Users\User\source\repos\KUAFÖR_RANDEVU_SİSTEMİ\MüsteriRandevuBilgileri.txt";

            if (File.Exists(dosyaYolu))
            {
                // CheckListBox'ı temizleyin ve dosyadan yeniden yükleyin
                checkedlistboxRandevuekle.Items.Clear(); // Var olan içeriği temizle

                var satırlar = File.ReadAllLines(dosyaYolu);

                foreach (var satır in satırlar)
                {
                    checkedlistboxRandevuekle.Items.Add(satır); // Dosyadaki her satırı ekle
                }
            }
            else
            {
                MessageBox.Show("Veri dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnRandevuEkleSil_Click(object sender, EventArgs e)
        {
            int selectedIndex = checkedlistboxRandevuekle.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek için bir öğe seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili öğeyi CheckListBox'tan sil
            string silinecekÖğe = checkedlistboxRandevuekle.SelectedItem.ToString();
            checkedlistboxRandevuekle.Items.RemoveAt(selectedIndex);

            // Dosyadan silinecek öğeyi sil
            SilRandevuDosyadan(silinecekÖğe);

            // Dosyayı tekrar yükleyerek CheckListBox'ı güncelle
            UpdateCheckedListBox();
        }

        private void SilRandevuDosyadan(string silinecekÖğe)
        {
            string dosyaYolu = @"C:\Users\User\source\repos\KUAFÖR_RANDEVU_SİSTEMİ\MüsteriRandevuBilgileri.txt";

            if (File.Exists(dosyaYolu))
            {
                var satırlar = File.ReadAllLines(dosyaYolu);

                // Yeni bir liste oluşturarak silinecek öğeyi çıkarın
                var yeniSatırlar = new List<string>();

                foreach (var satır in satırlar)
                {
                    if (satır != silinecekÖğe) // Eğer satır silinecek öğe değilse, ekleyin
                    {
                        yeniSatırlar.Add(satır);
                    }
                }

                // Dosyayı yeni listeyle tekrar yazın
                File.WriteAllLines(dosyaYolu, yeniSatırlar.ToArray());
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRandevuEkleDüzenle_Click(object sender, EventArgs e)
        {
            int selectedIndex = checkedlistboxRandevuekle.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Lütfen düzenlemek için bir randevu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen randevuyu alın
            string secilenRandevu = checkedlistboxRandevuekle.SelectedItem.ToString();

            // Mevcut randevu bilgilerini al
            var bilgiler = secilenRandevu.Split('/');

            // Randevu düzenleme alanlarını mevcut randevu bilgileriyle doldur
            txtRandevuEkleAd.Text = bilgiler[0];
            txtRandevuEkleSoyad.Text = bilgiler[1];
            maskedTextBoxRandevuEkleTelNo.Text = bilgiler[2];
            dateTimePickerRandevuEkle.Value = DateTime.Parse(bilgiler[3]);
            maskedTextBoxRandevuEklSaat.Text = bilgiler[4];
            comboBoxRandevuEklePersonel.SelectedItem = bilgiler[5];
            comboBoxRandevuEkleHizmet.SelectedItem = bilgiler[6];
        }




        private void GüncelleRandevuDosyası(string eskiRandevu, string yeniRandevu)
        {
            string dosyaYolu = @"C:\Users\User\source\repos\KUAFÖR_RANDEVU_SİSTEMİ\MüsteriRandevuBilgileri.txt";

            if (File.Exists(dosyaYolu))
            {
                var satırlar = File.ReadAllLines(dosyaYolu);

                // Yeni bir liste oluşturarak güncellenmiş randevuyu ekleyeceğiz
                var yeniSatırlar = new List<string>();

                foreach (var satır in satırlar)
                {
                    // Eski randevuyu "/" işaretine göre ayır
                    var randevuBilgileri = satır.Split('/');

                    // Eğer satırın ilk 3 bilgisi (ad, soyad, telefon) eski randevu ile aynı ise
                    if (randevuBilgileri[0] == eskiRandevu.Split('/')[0] &&
                        randevuBilgileri[1] == eskiRandevu.Split('/')[1] &&
                        randevuBilgileri[2] == eskiRandevu.Split('/')[2])
                    {
                        // Eğer eski randevu bu satıra eşitse, yeni randevuyu ekleme (silme işlemi)
                        continue; // Bu satırı atla (yani eski randevuyu sil)
                    }
                    else
                    {
                        // Eğer eşleşmiyorsa, satırı olduğu gibi koruyalım
                        yeniSatırlar.Add(satır);
                    }
                }

                // Dosyayı güncelleyelim
                File.WriteAllLines(dosyaYolu, yeniSatırlar);
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }

}
