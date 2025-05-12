namespace KUAFÖR_RANDEVU_SİSTEMİ
{
    partial class FrmMain
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
            btnrRandevuEkle = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnrRandevuEkle
            // 
            btnrRandevuEkle.BackColor = Color.FromArgb(255, 128, 0);
            btnrRandevuEkle.BackgroundImageLayout = ImageLayout.Stretch;
            btnrRandevuEkle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnrRandevuEkle.Location = new Point(342, 87);
            btnrRandevuEkle.Name = "btnrRandevuEkle";
            btnrRandevuEkle.Size = new Size(490, 151);
            btnrRandevuEkle.TabIndex = 0;
            btnrRandevuEkle.Text = "RANDEVU EKLE";
            btnrRandevuEkle.TextAlign = ContentAlignment.BottomCenter;
            btnrRandevuEkle.UseVisualStyleBackColor = false;
            btnrRandevuEkle.Click += btnrRandevuEkle_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(342, 308);
            button1.Name = "button1";
            button1.Size = new Size(490, 151);
            button1.TabIndex = 1;
            button1.Text = "HİZMETLER VE PERSONELLER";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1189, 563);
            Controls.Add(button1);
            Controls.Add(btnrRandevuEkle);
            Name = "FrmMain";
            Text = "Personel Takip";
            ResumeLayout(false);
        }

        #endregion

        private Button btnrRandevuEkle;
        private Button button1;
    }
}