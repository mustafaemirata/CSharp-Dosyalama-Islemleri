namespace Resim_
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
            this.renkSecBtn = new System.Windows.Forms.Button();
            this.resimSecBtn = new System.Windows.Forms.Button();
            this.yazdirBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoyut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // renkSecBtn
            // 
            this.renkSecBtn.Location = new System.Drawing.Point(124, 119);
            this.renkSecBtn.Name = "renkSecBtn";
            this.renkSecBtn.Size = new System.Drawing.Size(142, 48);
            this.renkSecBtn.TabIndex = 0;
            this.renkSecBtn.Text = "Renk Seç";
            this.renkSecBtn.UseVisualStyleBackColor = true;
            this.renkSecBtn.Click += new System.EventHandler(this.renkSecBtn_Click);
            // 
            // resimSecBtn
            // 
            this.resimSecBtn.Location = new System.Drawing.Point(124, 52);
            this.resimSecBtn.Name = "resimSecBtn";
            this.resimSecBtn.Size = new System.Drawing.Size(142, 48);
            this.resimSecBtn.TabIndex = 1;
            this.resimSecBtn.Text = "Resim Seç";
            this.resimSecBtn.UseVisualStyleBackColor = true;
            this.resimSecBtn.Click += new System.EventHandler(this.resimSecBtn_Click_1);
            // 
            // yazdirBtn
            // 
            this.yazdirBtn.Location = new System.Drawing.Point(124, 182);
            this.yazdirBtn.Name = "yazdirBtn";
            this.yazdirBtn.Size = new System.Drawing.Size(142, 48);
            this.yazdirBtn.TabIndex = 2;
            this.yazdirBtn.Text = "Yazdır";
            this.yazdirBtn.UseVisualStyleBackColor = true;
            this.yazdirBtn.Click += new System.EventHandler(this.yazdirBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(124, 252);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(142, 48);
            this.kaydetBtn.TabIndex = 3;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin:";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(105, 313);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(161, 34);
            this.txtMetin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boyut";
            // 
            // txtBoyut
            // 
            this.txtBoyut.Location = new System.Drawing.Point(105, 365);
            this.txtBoyut.Name = "txtBoyut";
            this.txtBoyut.Size = new System.Drawing.Size(161, 34);
            this.txtBoyut.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(484, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.kaydetBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.yazdirBtn);
            this.Controls.Add(this.resimSecBtn);
            this.Controls.Add(this.renkSecBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button renkSecBtn;
        private System.Windows.Forms.Button resimSecBtn;
        private System.Windows.Forms.Button yazdirBtn;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoyut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

