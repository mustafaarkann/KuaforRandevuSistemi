namespace KUAFÖR_RANDEVU_SİSTEMİ
{
    partial class HİZMETLİPERSONEL
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(123, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(167, 268);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "PERSONELLER\n\nAhmet Cebeci\nMurat Balım\nEren Berat\nBerat Resuloglu\nYusuf Ali Solmaz";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(404, 41);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(167, 268);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "HİZMETLER\n\nSaç Yıkama \nSaç Boyama\nSaç Kesimi \nMakyaj \nAğda\nDamat Tıraşı";
            // 
            // HİZMETLİPERSONEL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "HİZMETLİPERSONEL";
            Text = "HİZMETLİPERSONEL";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}