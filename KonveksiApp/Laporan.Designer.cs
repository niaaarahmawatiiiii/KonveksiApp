namespace KonveksiApp
{
    partial class Laporan
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laporan));
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnLapPesanan = new System.Windows.Forms.Button();
            this.btnLapProduksi = new System.Windows.Forms.Button();
            this.btnLapPembayaran = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.White;
            this.lblJudul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Maroon;
            this.lblJudul.Location = new System.Drawing.Point(271, 24);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(326, 33);
            this.lblJudul.TabIndex = 7;
            this.lblJudul.Text = "PILIH JENIS LAPORAN";
            // 
            // btnLapPesanan
            // 
            this.btnLapPesanan.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLapPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPesanan.ForeColor = System.Drawing.Color.White;
            this.btnLapPesanan.Location = new System.Drawing.Point(18, 78);
            this.btnLapPesanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLapPesanan.Name = "btnLapPesanan";
            this.btnLapPesanan.Size = new System.Drawing.Size(199, 46);
            this.btnLapPesanan.TabIndex = 6;
            this.btnLapPesanan.Text = "Laporan Pesanan";
            this.btnLapPesanan.UseVisualStyleBackColor = false;
            this.btnLapPesanan.Click += new System.EventHandler(this.btnLapPesanan_Click);
            // 
            // btnLapProduksi
            // 
            this.btnLapProduksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLapProduksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapProduksi.ForeColor = System.Drawing.Color.White;
            this.btnLapProduksi.Location = new System.Drawing.Point(227, 78);
            this.btnLapProduksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLapProduksi.Name = "btnLapProduksi";
            this.btnLapProduksi.Size = new System.Drawing.Size(199, 46);
            this.btnLapProduksi.TabIndex = 5;
            this.btnLapProduksi.Text = "Laporan Produksi";
            this.btnLapProduksi.UseVisualStyleBackColor = false;
            this.btnLapProduksi.Click += new System.EventHandler(this.btnLapProduksi_Click);
            // 
            // btnLapPembayaran
            // 
            this.btnLapPembayaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLapPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPembayaran.ForeColor = System.Drawing.Color.White;
            this.btnLapPembayaran.Location = new System.Drawing.Point(432, 78);
            this.btnLapPembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLapPembayaran.Name = "btnLapPembayaran";
            this.btnLapPembayaran.Size = new System.Drawing.Size(275, 46);
            this.btnLapPembayaran.TabIndex = 4;
            this.btnLapPembayaran.Text = "Laporan Pembayaran";
            this.btnLapPembayaran.UseVisualStyleBackColor = false;
            this.btnLapPembayaran.Click += new System.EventHandler(this.btnLapPembayaran_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Green;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(713, 78);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(172, 46);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.White;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKembali.Location = new System.Drawing.Point(757, 359);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(128, 39);
            this.btnKembali.TabIndex = 2;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.ColumnHeadersHeight = 29;
            this.dgvLaporan.Location = new System.Drawing.Point(18, 182);
            this.dgvLaporan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.Size = new System.Drawing.Size(867, 164);
            this.dgvLaporan.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(14, 145);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: -";
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(909, 409);
            this.Controls.Add(this.dgvLaporan);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLapPembayaran);
            this.Controls.Add(this.btnLapProduksi);
            this.Controls.Add(this.btnLapPesanan);
            this.Controls.Add(this.lblJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Laporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblJudul, lblTotal;
        private System.Windows.Forms.Button btnLapPesanan, btnLapProduksi, btnLapPembayaran, btnExport, btnKembali;
        private System.Windows.Forms.DataGridView dgvLaporan;
    }
}