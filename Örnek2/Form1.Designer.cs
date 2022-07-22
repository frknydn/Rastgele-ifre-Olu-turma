namespace Örnek2
{
    partial class Form1
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
            this.chkKarakter = new System.Windows.Forms.CheckBox();
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkSayi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.nupSayisi = new System.Windows.Forms.NumericUpDown();
            this.nupUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rchSifreler = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUzunlugu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkKarakter
            // 
            this.chkKarakter.AutoSize = true;
            this.chkKarakter.Location = new System.Drawing.Point(10, 130);
            this.chkKarakter.Name = "chkKarakter";
            this.chkKarakter.Size = new System.Drawing.Size(90, 17);
            this.chkKarakter.TabIndex = 0;
            this.chkKarakter.Text = "Özel Karakter";
            this.chkKarakter.UseVisualStyleBackColor = true;
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Location = new System.Drawing.Point(10, 19);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(80, 17);
            this.chkKucukHarf.TabIndex = 1;
            this.chkKucukHarf.Text = "Küçük Harf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Location = new System.Drawing.Point(10, 56);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.chkBuyukHarf.TabIndex = 2;
            this.chkBuyukHarf.Text = "Büyük Harf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkSayi
            // 
            this.chkSayi.AutoSize = true;
            this.chkSayi.Location = new System.Drawing.Point(10, 91);
            this.chkSayi.Name = "chkSayi";
            this.chkSayi.Size = new System.Drawing.Size(60, 17);
            this.chkSayi.TabIndex = 3;
            this.chkSayi.Text = "Rakam";
            this.chkSayi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifre Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre Uzunluğu";
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(92, 285);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(120, 44);
            this.btnUret.TabIndex = 6;
            this.btnUret.Text = "ÜRET";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // nupSayisi
            // 
            this.nupSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupSayisi.Location = new System.Drawing.Point(92, 187);
            this.nupSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSayisi.Name = "nupSayisi";
            this.nupSayisi.Size = new System.Drawing.Size(120, 20);
            this.nupSayisi.TabIndex = 7;
            this.nupSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupUzunlugu
            // 
            this.nupUzunlugu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupUzunlugu.Location = new System.Drawing.Point(92, 237);
            this.nupUzunlugu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupUzunlugu.Name = "nupUzunlugu";
            this.nupUzunlugu.Size = new System.Drawing.Size(120, 20);
            this.nupUzunlugu.TabIndex = 8;
            this.nupUzunlugu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBuyukHarf);
            this.groupBox1.Controls.Add(this.chkKarakter);
            this.groupBox1.Controls.Add(this.nupUzunlugu);
            this.groupBox1.Controls.Add(this.chkKucukHarf);
            this.groupBox1.Controls.Add(this.nupSayisi);
            this.groupBox1.Controls.Add(this.chkSayi);
            this.groupBox1.Controls.Add(this.btnUret);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 382);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rchSifreler
            // 
            this.rchSifreler.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rchSifreler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchSifreler.Location = new System.Drawing.Point(396, 20);
            this.rchSifreler.Name = "rchSifreler";
            this.rchSifreler.Size = new System.Drawing.Size(373, 374);
            this.rchSifreler.TabIndex = 9;
            this.rchSifreler.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 440);
            this.Controls.Add(this.rchSifreler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupUzunlugu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkKarakter;
        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.CheckBox chkSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.NumericUpDown nupSayisi;
        private System.Windows.Forms.NumericUpDown nupUzunlugu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchSifreler;
    }
}

