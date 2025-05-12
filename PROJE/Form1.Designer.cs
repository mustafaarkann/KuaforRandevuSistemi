namespace KUAFÖR_RANDEVU_SİSTEMİ
{
    partial class frmGiriş
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtloginNo = new TextBox();
            ttxtloginŞifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGiriş = new Button();
            btnKapat = new Button();
            SuspendLayout();
            // 
            // txtloginNo
            // 
            txtloginNo.Location = new Point(402, 124);
            txtloginNo.Name = "txtloginNo";
            txtloginNo.Size = new Size(154, 27);
            txtloginNo.TabIndex = 0;
            txtloginNo.KeyPress += textBox1_KeyPress;
            // 
            // ttxtloginŞifre
            // 
            ttxtloginŞifre.Location = new Point(402, 201);
            ttxtloginŞifre.Name = "ttxtloginŞifre";
            ttxtloginŞifre.Size = new Size(154, 27);
            ttxtloginŞifre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 112);
            label1.Name = "label1";
            label1.Size = new Size(64, 40);
            label1.TabIndex = 2;
            label1.Text = "NO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(254, 189);
            label2.Name = "label2";
            label2.Size = new Size(107, 40);
            label2.TabIndex = 3;
            label2.Text = "ŞİFRE";
            // 
            // btnGiriş
            // 
            btnGiriş.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiriş.Location = new Point(200, 326);
            btnGiriş.Name = "btnGiriş";
            btnGiriş.Size = new Size(138, 63);
            btnGiriş.TabIndex = 4;
            btnGiriş.Text = "GİRİŞ";
            btnGiriş.UseVisualStyleBackColor = true;
            btnGiriş.Click += btnGiriş_Click;
            // 
            // btnKapat
            // 
            btnKapat.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKapat.Location = new Point(418, 326);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(138, 63);
            btnKapat.TabIndex = 5;
            btnKapat.Text = "KAPAT";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // frmGiriş
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 505);
            Controls.Add(btnKapat);
            Controls.Add(btnGiriş);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ttxtloginŞifre);
            Controls.Add(txtloginNo);
            Name = "frmGiriş";
            Text = "KULLANICI GİRİŞİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtloginNo;
        private TextBox ttxtloginŞifre;
        private Label label1;
        private Label label2;
        private Button btnGiriş;
        private Button btnKapat;
    }
}