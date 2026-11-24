namespace KonveksiApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.lblTotalPesanan = new System.Windows.Forms.Label();
            this.grpProduksi = new System.Windows.Forms.GroupBox();
            this.lblProduksi = new System.Windows.Forms.Label();
            this.grpSelesai = new System.Windows.Forms.GroupBox();
            this.lblSelesai = new System.Windows.Forms.Label();
            this.grpBelumLunas = new System.Windows.Forms.GroupBox();
            this.lblBelumLunas = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnPesanan = new System.Windows.Forms.Button();
            this.btnProduksi = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpTotal.SuspendLayout();
            this.grpProduksi.SuspendLayout();
            this.grpSelesai.SuspendLayout();
            this.grpBelumLunas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD KONVEKSI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.lblTotalPesanan);
            this.grpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpTotal.Location = new System.Drawing.Point(27, 98);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(197, 96);
            this.grpTotal.TabIndex = 2;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total Pesanan";
            // 
            // lblTotalPesanan
            // 
            this.lblTotalPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPesanan.Location = new System.Drawing.Point(0, 35);
            this.lblTotalPesanan.Name = "lblTotalPesanan";
            this.lblTotalPesanan.Size = new System.Drawing.Size(180, 50);
            this.lblTotalPesanan.TabIndex = 0;
            this.lblTotalPesanan.Text = "0";
            this.lblTotalPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpProduksi
            // 
            this.grpProduksi.Controls.Add(this.lblProduksi);
            this.grpProduksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduksi.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpProduksi.Location = new System.Drawing.Point(230, 98);
            this.grpProduksi.Name = "grpProduksi";
            this.grpProduksi.Size = new System.Drawing.Size(197, 96);
            this.grpProduksi.TabIndex = 3;
            this.grpProduksi.TabStop = false;
            this.grpProduksi.Text = "Sedang Diproduksi";
            // 
            // lblProduksi
            // 
            this.lblProduksi.AutoSize = true;
            this.lblProduksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduksi.Location = new System.Drawing.Point(74, 35);
            this.lblProduksi.Name = "lblProduksi";
            this.lblProduksi.Size = new System.Drawing.Size(43, 46);
            this.lblProduksi.TabIndex = 0;
            this.lblProduksi.Text = "0";
            this.lblProduksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSelesai
            // 
            this.grpSelesai.Controls.Add(this.lblSelesai);
            this.grpSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelesai.ForeColor = System.Drawing.Color.DarkBlue;
            this.grpSelesai.Location = new System.Drawing.Point(433, 98);
            this.grpSelesai.Name = "grpSelesai";
            this.grpSelesai.Size = new System.Drawing.Size(197, 96);
            this.grpSelesai.TabIndex = 4;
            this.grpSelesai.TabStop = false;
            this.grpSelesai.Text = "Pesanan Selesai";
            // 
            // lblSelesai
            // 
            this.lblSelesai.AutoSize = true;
            this.lblSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelesai.Location = new System.Drawing.Point(71, 35);
            this.lblSelesai.Name = "lblSelesai";
            this.lblSelesai.Size = new System.Drawing.Size(43, 46);
            this.lblSelesai.TabIndex = 0;
            this.lblSelesai.Text = "0";
            // 
            // grpBelumLunas
            // 
            this.grpBelumLunas.Controls.Add(this.lblBelumLunas);
            this.grpBelumLunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBelumLunas.ForeColor = System.Drawing.Color.DarkRed;
            this.grpBelumLunas.Location = new System.Drawing.Point(636, 98);
            this.grpBelumLunas.Name = "grpBelumLunas";
            this.grpBelumLunas.Size = new System.Drawing.Size(197, 96);
            this.grpBelumLunas.TabIndex = 5;
            this.grpBelumLunas.TabStop = false;
            this.grpBelumLunas.Text = "Belum Lunas";
            // 
            // lblBelumLunas
            // 
            this.lblBelumLunas.AutoSize = true;
            this.lblBelumLunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelumLunas.Location = new System.Drawing.Point(70, 33);
            this.lblBelumLunas.Name = "lblBelumLunas";
            this.lblBelumLunas.Size = new System.Drawing.Size(43, 46);
            this.lblBelumLunas.TabIndex = 0;
            this.lblBelumLunas.Text = "0";
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(26, 212);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(198, 61);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Data Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPesanan
            // 
            this.btnPesanan.BackColor = System.Drawing.Color.Blue;
            this.btnPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPesanan.ForeColor = System.Drawing.Color.White;
            this.btnPesanan.Location = new System.Drawing.Point(230, 212);
            this.btnPesanan.Name = "btnPesanan";
            this.btnPesanan.Size = new System.Drawing.Size(197, 61);
            this.btnPesanan.TabIndex = 7;
            this.btnPesanan.Text = "Data Pesanan";
            this.btnPesanan.UseVisualStyleBackColor = false;
            this.btnPesanan.Click += new System.EventHandler(this.btnPesanan_Click);
            // 
            // btnProduksi
            // 
            this.btnProduksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProduksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnProduksi.ForeColor = System.Drawing.Color.White;
            this.btnProduksi.Location = new System.Drawing.Point(433, 212);
            this.btnProduksi.Name = "btnProduksi";
            this.btnProduksi.Size = new System.Drawing.Size(197, 61);
            this.btnProduksi.TabIndex = 8;
            this.btnProduksi.Text = "Data Produksi";
            this.btnProduksi.UseVisualStyleBackColor = false;
            this.btnProduksi.Click += new System.EventHandler(this.btnProduksi_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(636, 212);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(197, 61);
            this.btnLaporan.TabIndex = 9;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(739, 291);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 37);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(855, 339);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnProduksi);
            this.Controls.Add(this.btnPesanan);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.grpBelumLunas);
            this.Controls.Add(this.grpSelesai);
            this.Controls.Add(this.grpProduksi);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.grpTotal.ResumeLayout(false);
            this.grpProduksi.ResumeLayout(false);
            this.grpProduksi.PerformLayout();
            this.grpSelesai.ResumeLayout(false);
            this.grpSelesai.PerformLayout();
            this.grpBelumLunas.ResumeLayout(false);
            this.grpBelumLunas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Label lblTotalPesanan;
        private System.Windows.Forms.GroupBox grpProduksi;
        private System.Windows.Forms.Label lblProduksi;
        private System.Windows.Forms.GroupBox grpSelesai;
        private System.Windows.Forms.Label lblSelesai;
        private System.Windows.Forms.GroupBox grpBelumLunas;
        private System.Windows.Forms.Label lblBelumLunas;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnPesanan;
        private System.Windows.Forms.Button btnProduksi;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnLogout;
    }
}