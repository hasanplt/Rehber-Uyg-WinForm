namespace RehberUygProje
{
    partial class KayitDetay
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNumara = new System.Windows.Forms.MaskedTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnKayitSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDetay = new System.Windows.Forms.Button();
            this.TxtDetayDeger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDetayTip = new System.Windows.Forms.TextBox();
            this.BtnDetayGetir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isim:";
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(114, 38);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 20);
            this.TxtIsim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numara:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNumara);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.BtnKayitSil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtIsim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana Kısım";
            // 
            // TxtNumara
            // 
            this.TxtNumara.Location = new System.Drawing.Point(114, 74);
            this.TxtNumara.Mask = "+900000000000";
            this.TxtNumara.Name = "TxtNumara";
            this.TxtNumara.Size = new System.Drawing.Size(100, 20);
            this.TxtNumara.TabIndex = 1;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(125, 110);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnKayitSil
            // 
            this.BtnKayitSil.Location = new System.Drawing.Point(15, 105);
            this.BtnKayitSil.Name = "BtnKayitSil";
            this.BtnKayitSil.Size = new System.Drawing.Size(99, 33);
            this.BtnKayitSil.TabIndex = 3;
            this.BtnKayitSil.Text = "Kayıtı Sil";
            this.BtnKayitSil.UseVisualStyleBackColor = true;
            this.BtnKayitSil.Click += new System.EventHandler(this.BtnKayitSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 172);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDetay);
            this.groupBox2.Controls.Add(this.TxtDetayDeger);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtDetayTip);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 147);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detay Ekle";
            // 
            // BtnDetay
            // 
            this.BtnDetay.Location = new System.Drawing.Point(161, 110);
            this.BtnDetay.Name = "BtnDetay";
            this.BtnDetay.Size = new System.Drawing.Size(75, 23);
            this.BtnDetay.TabIndex = 6;
            this.BtnDetay.Text = "Ekle";
            this.BtnDetay.UseVisualStyleBackColor = true;
            this.BtnDetay.Click += new System.EventHandler(this.BtnDetay_Click);
            // 
            // TxtDetayDeger
            // 
            this.TxtDetayDeger.Location = new System.Drawing.Point(149, 69);
            this.TxtDetayDeger.Name = "TxtDetayDeger";
            this.TxtDetayDeger.Size = new System.Drawing.Size(100, 20);
            this.TxtDetayDeger.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detay Tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Detay Değeri:";
            // 
            // TxtDetayTip
            // 
            this.TxtDetayTip.Location = new System.Drawing.Point(149, 33);
            this.TxtDetayTip.Name = "TxtDetayTip";
            this.TxtDetayTip.Size = new System.Drawing.Size(100, 20);
            this.TxtDetayTip.TabIndex = 4;
            // 
            // BtnDetayGetir
            // 
            this.BtnDetayGetir.Location = new System.Drawing.Point(12, 343);
            this.BtnDetayGetir.Name = "BtnDetayGetir";
            this.BtnDetayGetir.Size = new System.Drawing.Size(99, 33);
            this.BtnDetayGetir.TabIndex = 8;
            this.BtnDetayGetir.Text = "Detayları Getir";
            this.BtnDetayGetir.UseVisualStyleBackColor = true;
            this.BtnDetayGetir.Click += new System.EventHandler(this.BtnDetayGetir_Click);
            // 
            // KayitDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 388);
            this.Controls.Add(this.BtnDetayGetir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "KayitDetay";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Detayı";
            this.Load += new System.EventHandler(this.KayitDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnKayitSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDetay;
        private System.Windows.Forms.TextBox TxtDetayDeger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDetayTip;
        private System.Windows.Forms.Button BtnDetayGetir;
        private System.Windows.Forms.MaskedTextBox TxtNumara;
    }
}