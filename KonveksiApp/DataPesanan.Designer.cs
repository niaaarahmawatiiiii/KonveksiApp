namespace KonveksiApp
{
    partial class DataPesanan
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPesanan));
            this.lblJudul = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtJenis = new System.Windows.Forms.TextBox();
            this.lblJenis = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.cmbUkuran = new System.Windows.Forms.ComboBox();
            this.lblUkuran = new System.Windows.Forms.Label();
            this.cmbWarna = new System.Windows.Forms.ComboBox();
            this.lblWarna = new System.Windows.Forms.Label();
            this.cmbBahan = new System.Windows.Forms.ComboBox();
            this.lblBahan = new System.Windows.Forms.Label();
            this.cmbSablon = new System.Windows.Forms.ComboBox();
            this.lblSablon = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.cmbHargaSatuan = new System.Windows.Forms.ComboBox();
            this.lblHargaSatuan = new System.Windows.Forms.Label();
            this.txtHargaTotal = new System.Windows.Forms.TextBox();
            this.lblHargaTotal = new System.Windows.Forms.Label();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.lblDP = new System.Windows.Forms.Label();
            this.txtSisa = new System.Windows.Forms.TextBox();
            this.lblSisa = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnWA = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPelunasan = new System.Windows.Forms.Label();
            this.txtPelunasan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.White;
            this.lblJudul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.Maroon;
            this.lblJudul.Location = new System.Drawing.Point(303, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(254, 34);
            this.lblJudul.TabIndex = 29;
            this.lblJudul.Text = "INPUT PESANAN";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Location = new System.Drawing.Point(225, 57);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(233, 24);
            this.cmbCustomer.TabIndex = 28;
            // 
            // txtJenis
            // 
            this.txtJenis.Location = new System.Drawing.Point(225, 98);
            this.txtJenis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.Size = new System.Drawing.Size(233, 22);
            this.txtJenis.TabIndex = 26;
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenis.Location = new System.Drawing.Point(36, 98);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(132, 20);
            this.lblJenis.TabIndex = 27;
            this.lblJenis.Text = "Jenis Pakaian:";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(225, 127);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(233, 22);
            this.txtJumlah.TabIndex = 24;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(36, 127);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(75, 20);
            this.lblJumlah.TabIndex = 25;
            this.lblJumlah.Text = "Jumlah:";
            // 
            // cmbUkuran
            // 
            this.cmbUkuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUkuran.Location = new System.Drawing.Point(225, 156);
            this.cmbUkuran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUkuran.Name = "cmbUkuran";
            this.cmbUkuran.Size = new System.Drawing.Size(233, 24);
            this.cmbUkuran.TabIndex = 22;
            // 
            // lblUkuran
            // 
            this.lblUkuran.AutoSize = true;
            this.lblUkuran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkuran.Location = new System.Drawing.Point(36, 156);
            this.lblUkuran.Name = "lblUkuran";
            this.lblUkuran.Size = new System.Drawing.Size(74, 20);
            this.lblUkuran.TabIndex = 23;
            this.lblUkuran.Text = "Ukuran:";
            // 
            // cmbWarna
            // 
            this.cmbWarna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarna.Location = new System.Drawing.Point(225, 189);
            this.cmbWarna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbWarna.Name = "cmbWarna";
            this.cmbWarna.Size = new System.Drawing.Size(233, 24);
            this.cmbWarna.TabIndex = 20;
            // 
            // lblWarna
            // 
            this.lblWarna.AutoSize = true;
            this.lblWarna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarna.Location = new System.Drawing.Point(36, 189);
            this.lblWarna.Name = "lblWarna";
            this.lblWarna.Size = new System.Drawing.Size(69, 20);
            this.lblWarna.TabIndex = 21;
            this.lblWarna.Text = "Warna:";
            // 
            // cmbBahan
            // 
            this.cmbBahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBahan.Location = new System.Drawing.Point(225, 222);
            this.cmbBahan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBahan.Name = "cmbBahan";
            this.cmbBahan.Size = new System.Drawing.Size(233, 24);
            this.cmbBahan.TabIndex = 18;
            // 
            // lblBahan
            // 
            this.lblBahan.AutoSize = true;
            this.lblBahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBahan.Location = new System.Drawing.Point(36, 222);
            this.lblBahan.Name = "lblBahan";
            this.lblBahan.Size = new System.Drawing.Size(68, 20);
            this.lblBahan.TabIndex = 19;
            this.lblBahan.Text = "Bahan:";
            // 
            // cmbSablon
            // 
            this.cmbSablon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSablon.Location = new System.Drawing.Point(225, 259);
            this.cmbSablon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSablon.Name = "cmbSablon";
            this.cmbSablon.Size = new System.Drawing.Size(233, 24);
            this.cmbSablon.TabIndex = 16;
            // 
            // lblSablon
            // 
            this.lblSablon.AutoSize = true;
            this.lblSablon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSablon.Location = new System.Drawing.Point(36, 259);
            this.lblSablon.Name = "lblSablon";
            this.lblSablon.Size = new System.Drawing.Size(130, 20);
            this.lblSablon.TabIndex = 17;
            this.lblSablon.Text = "Sablon/Bordir:";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(225, 292);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(233, 22);
            this.dtpDeadline.TabIndex = 14;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(36, 294);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(89, 20);
            this.lblDeadline.TabIndex = 15;
            this.lblDeadline.Text = "Deadline:";
            // 
            // cmbHargaSatuan
            // 
            this.cmbHargaSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHargaSatuan.Location = new System.Drawing.Point(598, 55);
            this.cmbHargaSatuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHargaSatuan.Name = "cmbHargaSatuan";
            this.cmbHargaSatuan.Size = new System.Drawing.Size(178, 24);
            this.cmbHargaSatuan.TabIndex = 12;
            // 
            // lblHargaSatuan
            // 
            this.lblHargaSatuan.AutoSize = true;
            this.lblHargaSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaSatuan.Location = new System.Drawing.Point(475, 55);
            this.lblHargaSatuan.Name = "lblHargaSatuan";
            this.lblHargaSatuan.Size = new System.Drawing.Size(117, 20);
            this.lblHargaSatuan.TabIndex = 13;
            this.lblHargaSatuan.Text = "Harga Satuan:";
            // 
            // txtHargaTotal
            // 
            this.txtHargaTotal.Location = new System.Drawing.Point(598, 86);
            this.txtHargaTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHargaTotal.Name = "txtHargaTotal";
            this.txtHargaTotal.ReadOnly = true;
            this.txtHargaTotal.Size = new System.Drawing.Size(178, 22);
            this.txtHargaTotal.TabIndex = 10;
            // 
            // lblHargaTotal
            // 
            this.lblHargaTotal.AutoSize = true;
            this.lblHargaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaTotal.Location = new System.Drawing.Point(475, 83);
            this.lblHargaTotal.Name = "lblHargaTotal";
            this.lblHargaTotal.Size = new System.Drawing.Size(102, 20);
            this.lblHargaTotal.TabIndex = 11;
            this.lblHargaTotal.Text = "Harga Total:";
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(598, 115);
            this.txtDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(178, 22);
            this.txtDP.TabIndex = 8;
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDP.Location = new System.Drawing.Point(475, 115);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(38, 20);
            this.lblDP.TabIndex = 9;
            this.lblDP.Text = "DP:";
            // 
            // txtSisa
            // 
            this.txtSisa.Location = new System.Drawing.Point(598, 147);
            this.txtSisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSisa.Name = "txtSisa";
            this.txtSisa.ReadOnly = true;
            this.txtSisa.Size = new System.Drawing.Size(178, 22);
            this.txtSisa.TabIndex = 6;
            // 
            // lblSisa
            // 
            this.lblSisa.AutoSize = true;
            this.lblSisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSisa.Location = new System.Drawing.Point(475, 147);
            this.lblSisa.Name = "lblSisa";
            this.lblSisa.Size = new System.Drawing.Size(96, 20);
            this.lblSisa.TabIndex = 7;
            this.lblSisa.Text = "Sisa Bayar:";
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.Color.Blue;
            this.btnHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitung.ForeColor = System.Drawing.Color.White;
            this.btnHitung.Location = new System.Drawing.Point(478, 214);
            this.btnHitung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(137, 33);
            this.btnHitung.TabIndex = 5;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(478, 250);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(297, 38);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(639, 214);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 33);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnWA
            // 
            this.btnWA.BackColor = System.Drawing.Color.Lime;
            this.btnWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWA.ForeColor = System.Drawing.Color.Black;
            this.btnWA.Location = new System.Drawing.Point(479, 292);
            this.btnWA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWA.Name = "btnWA";
            this.btnWA.Size = new System.Drawing.Size(137, 33);
            this.btnWA.TabIndex = 2;
            this.btnWA.Text = "WhatsApp";
            this.btnWA.UseVisualStyleBackColor = false;
            this.btnWA.Click += new System.EventHandler(this.btnWA_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.White;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.Black;
            this.btnKembali.Location = new System.Drawing.Point(638, 292);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(137, 33);
            this.btnKembali.TabIndex = 1;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.AllowUserToAddRows = false;
            this.dgvPesanan.ColumnHeadersHeight = 29;
            this.dgvPesanan.Location = new System.Drawing.Point(39, 336);
            this.dgvPesanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.RowHeadersWidth = 51;
            this.dgvPesanan.Size = new System.Drawing.Size(737, 144);
            this.dgvPesanan.TabIndex = 0;
            this.dgvPesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesanan_CellClick);
            this.dgvPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesanan_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Customer";
            // 
            // lblPelunasan
            // 
            this.lblPelunasan.AutoSize = true;
            this.lblPelunasan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelunasan.Location = new System.Drawing.Point(475, 179);
            this.lblPelunasan.Name = "lblPelunasan";
            this.lblPelunasan.Size = new System.Drawing.Size(92, 20);
            this.lblPelunasan.TabIndex = 31;
            this.lblPelunasan.Text = "Pelunasan:";
            // 
            // txtPelunasan
            // 
            this.txtPelunasan.Location = new System.Drawing.Point(598, 179);
            this.txtPelunasan.Name = "txtPelunasan";
            this.txtPelunasan.Size = new System.Drawing.Size(178, 22);
            this.txtPelunasan.TabIndex = 32;
            // 
            // DataPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(831, 496);
            this.Controls.Add(this.txtPelunasan);
            this.Controls.Add(this.lblPelunasan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnWA);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtSisa);
            this.Controls.Add(this.lblSisa);
            this.Controls.Add(this.txtDP);
            this.Controls.Add(this.lblDP);
            this.Controls.Add(this.txtHargaTotal);
            this.Controls.Add(this.lblHargaTotal);
            this.Controls.Add(this.cmbHargaSatuan);
            this.Controls.Add(this.lblHargaSatuan);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.cmbSablon);
            this.Controls.Add(this.lblSablon);
            this.Controls.Add(this.cmbBahan);
            this.Controls.Add(this.lblBahan);
            this.Controls.Add(this.cmbWarna);
            this.Controls.Add(this.lblWarna);
            this.Controls.Add(this.cmbUkuran);
            this.Controls.Add(this.lblUkuran);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.txtJenis);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Pesanan";
            this.Load += new System.EventHandler(this.DataPesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblJudul, lblJenis, lblJumlah, lblUkuran, lblWarna, lblBahan, lblSablon, lblDeadline, lblHargaSatuan, lblHargaTotal, lblDP, lblSisa;
        private System.Windows.Forms.ComboBox cmbCustomer, cmbUkuran, cmbWarna, cmbBahan, cmbSablon, cmbHargaSatuan;
        private System.Windows.Forms.TextBox txtJenis, txtJumlah, txtHargaTotal, txtDP, txtSisa;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Button btnHitung, btnSimpan, btnReset, btnWA, btnKembali;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPelunasan;
        private System.Windows.Forms.TextBox txtPelunasan;
    }
}