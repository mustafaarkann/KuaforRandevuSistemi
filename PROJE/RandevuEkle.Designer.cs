namespace KUAFÖR_RANDEVU_SİSTEMİ
{
    partial class frmRandevuEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtRandevuEkleAd = new TextBox();
            txtRandevuEkleSoyad = new TextBox();
            maskedTextBoxRandevuEklSaat = new MaskedTextBox();
            dateTimePickerRandevuEkle = new DateTimePicker();
            maskedTextBoxRandevuEkleTelNo = new MaskedTextBox();
            comboBoxRandevuEkleHizmet = new ComboBox();
            comboBoxRandevuEklePersonel = new ComboBox();
            btnRandevuEkleEkle = new Button();
            btnRandevuEkleGeri = new Button();
            label7 = new Label();
            checkedlistboxRandevuekle = new CheckedListBox();
            btnRandevuEkleDüzenle = new Button();
            btnRandevuEkleSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 39);
            label1.Name = "label1";
            label1.Size = new Size(47, 31);
            label1.TabIndex = 0;
            label1.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 87);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 1;
            label2.Text = "SOYAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 155);
            label3.Name = "label3";
            label3.Size = new Size(92, 31);
            label3.TabIndex = 2;
            label3.Text = "TEL NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 210);
            label4.Name = "label4";
            label4.Size = new Size(81, 31);
            label4.TabIndex = 3;
            label4.Text = "TARİH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(43, 273);
            label5.Name = "label5";
            label5.Size = new Size(70, 31);
            label5.TabIndex = 4;
            label5.Text = "SAAT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(43, 336);
            label6.Name = "label6";
            label6.Size = new Size(100, 31);
            label6.TabIndex = 5;
            label6.Text = "HİZMET";
            // 
            // txtRandevuEkleAd
            // 
            txtRandevuEkleAd.Location = new Point(179, 39);
            txtRandevuEkleAd.Name = "txtRandevuEkleAd";
            txtRandevuEkleAd.Size = new Size(125, 27);
            txtRandevuEkleAd.TabIndex = 7;
            // 
            // txtRandevuEkleSoyad
            // 
            txtRandevuEkleSoyad.Location = new Point(179, 93);
            txtRandevuEkleSoyad.Name = "txtRandevuEkleSoyad";
            txtRandevuEkleSoyad.Size = new Size(125, 27);
            txtRandevuEkleSoyad.TabIndex = 8;
            // 
            // maskedTextBoxRandevuEklSaat
            // 
            maskedTextBoxRandevuEklSaat.Location = new Point(179, 277);
            maskedTextBoxRandevuEklSaat.Mask = "00:00";
            maskedTextBoxRandevuEklSaat.Name = "maskedTextBoxRandevuEklSaat";
            maskedTextBoxRandevuEklSaat.Size = new Size(125, 27);
            maskedTextBoxRandevuEklSaat.TabIndex = 10;
            maskedTextBoxRandevuEklSaat.ValidatingType = typeof(DateTime);
            // 
            // dateTimePickerRandevuEkle
            // 
            dateTimePickerRandevuEkle.Location = new Point(179, 214);
            dateTimePickerRandevuEkle.Name = "dateTimePickerRandevuEkle";
            dateTimePickerRandevuEkle.Size = new Size(250, 27);
            dateTimePickerRandevuEkle.TabIndex = 11;
            // 
            // maskedTextBoxRandevuEkleTelNo
            // 
            maskedTextBoxRandevuEkleTelNo.Location = new Point(179, 161);
            maskedTextBoxRandevuEkleTelNo.Mask = "(999) 000-0000";
            maskedTextBoxRandevuEkleTelNo.Name = "maskedTextBoxRandevuEkleTelNo";
            maskedTextBoxRandevuEkleTelNo.Size = new Size(125, 27);
            maskedTextBoxRandevuEkleTelNo.TabIndex = 12;
            // 
            // comboBoxRandevuEkleHizmet
            // 
            comboBoxRandevuEkleHizmet.FormattingEnabled = true;
            comboBoxRandevuEkleHizmet.Items.AddRange(new object[] { "Saç Boyama  600TL", "Saç Yıkama   300TL", "Saç Kesimi    750TL", "Makyaj          500TL", "Ağda             300TL", "Damat Tıraşı 1500TL" });
            comboBoxRandevuEkleHizmet.Location = new Point(179, 339);
            comboBoxRandevuEkleHizmet.Name = "comboBoxRandevuEkleHizmet";
            comboBoxRandevuEkleHizmet.Size = new Size(151, 28);
            comboBoxRandevuEkleHizmet.TabIndex = 13;
            // 
            // comboBoxRandevuEklePersonel
            // 
            comboBoxRandevuEklePersonel.FormattingEnabled = true;
            comboBoxRandevuEklePersonel.Items.AddRange(new object[] { "Murat Balım", "Mısra Meral", "Ahmet Cebeci", "Eren Berat", "Berat Resulson" });
            comboBoxRandevuEklePersonel.Location = new Point(179, 403);
            comboBoxRandevuEklePersonel.Name = "comboBoxRandevuEklePersonel";
            comboBoxRandevuEklePersonel.Size = new Size(151, 28);
            comboBoxRandevuEklePersonel.TabIndex = 14;
            // 
            // btnRandevuEkleEkle
            // 
            btnRandevuEkleEkle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandevuEkleEkle.Location = new Point(89, 476);
            btnRandevuEkleEkle.Name = "btnRandevuEkleEkle";
            btnRandevuEkleEkle.Size = new Size(149, 69);
            btnRandevuEkleEkle.TabIndex = 15;
            btnRandevuEkleEkle.Text = "EKLE";
            btnRandevuEkleEkle.UseVisualStyleBackColor = true;
            btnRandevuEkleEkle.Click += btnRandevuEkleEkle_Click;
            // 
            // btnRandevuEkleGeri
            // 
            btnRandevuEkleGeri.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandevuEkleGeri.Location = new Point(697, 476);
            btnRandevuEkleGeri.Name = "btnRandevuEkleGeri";
            btnRandevuEkleGeri.Size = new Size(149, 69);
            btnRandevuEkleGeri.TabIndex = 16;
            btnRandevuEkleGeri.Text = "GERİ";
            btnRandevuEkleGeri.UseVisualStyleBackColor = true;
            btnRandevuEkleGeri.Click += btnRandevuEkleGeri_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(43, 397);
            label7.Name = "label7";
            label7.Size = new Size(127, 31);
            label7.TabIndex = 17;
            label7.Text = "PERSONEL";
            // 
            // checkedlistboxRandevuekle
            // 
            checkedlistboxRandevuekle.FormattingEnabled = true;
            checkedlistboxRandevuekle.Location = new Point(435, 39);
            checkedlistboxRandevuekle.Name = "checkedlistboxRandevuekle";
            checkedlistboxRandevuekle.Size = new Size(519, 400);
            checkedlistboxRandevuekle.TabIndex = 18;
            // 
            // btnRandevuEkleDüzenle
            // 
            btnRandevuEkleDüzenle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandevuEkleDüzenle.Location = new Point(290, 476);
            btnRandevuEkleDüzenle.Name = "btnRandevuEkleDüzenle";
            btnRandevuEkleDüzenle.Size = new Size(149, 69);
            btnRandevuEkleDüzenle.TabIndex = 19;
            btnRandevuEkleDüzenle.Text = "DÜZENLE";
            btnRandevuEkleDüzenle.UseVisualStyleBackColor = true;
            btnRandevuEkleDüzenle.Click += btnRandevuEkleDüzenle_Click;
            // 
            // btnRandevuEkleSil
            // 
            btnRandevuEkleSil.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandevuEkleSil.Location = new Point(487, 476);
            btnRandevuEkleSil.Name = "btnRandevuEkleSil";
            btnRandevuEkleSil.Size = new Size(149, 69);
            btnRandevuEkleSil.TabIndex = 20;
            btnRandevuEkleSil.Text = "SİL";
            btnRandevuEkleSil.UseVisualStyleBackColor = true;
            btnRandevuEkleSil.Click += btnRandevuEkleSil_Click;
            // 
            // frmRandevuEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(966, 665);
            Controls.Add(btnRandevuEkleSil);
            Controls.Add(btnRandevuEkleDüzenle);
            Controls.Add(checkedlistboxRandevuekle);
            Controls.Add(label7);
            Controls.Add(btnRandevuEkleGeri);
            Controls.Add(btnRandevuEkleEkle);
            Controls.Add(comboBoxRandevuEklePersonel);
            Controls.Add(comboBoxRandevuEkleHizmet);
            Controls.Add(maskedTextBoxRandevuEkleTelNo);
            Controls.Add(dateTimePickerRandevuEkle);
            Controls.Add(maskedTextBoxRandevuEklSaat);
            Controls.Add(txtRandevuEkleSoyad);
            Controls.Add(txtRandevuEkleAd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRandevuEkle";
            Text = "Randevu Ekle";
            Load += RandevuEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRandevuEkleEkle;
        private Button btnRandevuEkleGeri;
        public TextBox txtRandevuEkleAd;
        public TextBox txtRandevuEkleSoyad;
        public MaskedTextBox maskedTextBoxRandevuEklSaat;
        public DateTimePicker dateTimePickerRandevuEkle;
        public MaskedTextBox maskedTextBoxRandevuEkleTelNo;
        public ComboBox comboBoxRandevuEkleHizmet;
        public ComboBox comboBoxRandevuEklePersonel;
        private Label label7;
        public CheckedListBox checkedlistboxRandevuekle;
        public Button btnRandevuEkleDüzenle;
        public Button btnRandevuEkleSil;
    }
}