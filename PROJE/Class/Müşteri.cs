using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUAFÖR_RANDEVU_SİSTEMİ.Class
{
    public class Müşteri
    {

        frmRandevuEkle frmrndvekle=new frmRandevuEkle();
       public  Müşteri(string Müşteriad,string Müşterisoyad,string Müşteritelno) 
        {
            Müşteriad = frmrndvekle.txtRandevuEkleAd.Text;
            Müşterisoyad = frmrndvekle.txtRandevuEkleSoyad.Text;
            Müşteritelno=frmrndvekle.maskedTextBoxRandevuEkleTelNo.Text;
        }    
        
        }

        
    }

