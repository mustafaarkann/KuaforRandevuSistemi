using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUAFÖR_RANDEVU_SİSTEMİ
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnrRandevuEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRandevuEkle randevuEkle = new frmRandevuEkle();
            randevuEkle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HİZMETLİPERSONEL frmhp=new HİZMETLİPERSONEL();
            frmhp.ShowDialog();
        }
    }
}
