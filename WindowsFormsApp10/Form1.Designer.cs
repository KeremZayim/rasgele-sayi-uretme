
namespace WindowsFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBDegisken = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.TBBaslangic = new System.Windows.Forms.TextBox();
            this.tbBitis = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.tBAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBDegisken
            // 
            this.LBDegisken.FormattingEnabled = true;
            this.LBDegisken.Location = new System.Drawing.Point(12, 38);
            this.LBDegisken.Name = "LBDegisken";
            this.LBDegisken.Size = new System.Drawing.Size(208, 407);
            this.LBDegisken.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Degiskenler";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(385, 371);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(97, 35);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Ekle";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslangic.Location = new System.Drawing.Point(278, 281);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(100, 20);
            this.lblBaslangic.TabIndex = 3;
            this.lblBaslangic.Text = "Baslangıc:";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitis.Location = new System.Drawing.Point(322, 308);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(56, 20);
            this.lblBitis.TabIndex = 4;
            this.lblBitis.Text = "Bitis:";
            // 
            // TBBaslangic
            // 
            this.TBBaslangic.Location = new System.Drawing.Point(382, 281);
            this.TBBaslangic.Name = "TBBaslangic";
            this.TBBaslangic.Size = new System.Drawing.Size(100, 20);
            this.TBBaslangic.TabIndex = 5;
            // 
            // tbBitis
            // 
            this.tbBitis.Location = new System.Drawing.Point(382, 308);
            this.tbBitis.Name = "tbBitis";
            this.tbBitis.Size = new System.Drawing.Size(100, 20);
            this.tbBitis.TabIndex = 6;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(254, 371);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(97, 35);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // tBAdet
            // 
            this.tBAdet.Location = new System.Drawing.Point(382, 336);
            this.tBAdet.Name = "tBAdet";
            this.tBAdet.Size = new System.Drawing.Size(100, 20);
            this.tBAdet.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBAdet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.tbBitis);
            this.Controls.Add(this.TBBaslangic);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBDegisken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBDegisken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.TextBox TBBaslangic;
        private System.Windows.Forms.TextBox tbBitis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox tBAdet;
        private System.Windows.Forms.Label label2;
    }
}

