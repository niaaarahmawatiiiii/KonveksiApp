namespace KonveksiApp
{
    partial class DataProduksi
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataProduksi));
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblKet = new System.Windows.Forms.Label();
            this.txtKet = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnWA = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.dgvProduksi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduksi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.White;
            this.lblJudul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Maroon;
            this.lblJudul.Location = new System.Drawing.Point(112, 19);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(363, 33);
            this.lblJudul.TabIndex = 8;
            this.lblJudul.Text = "MONITORING PRODUKSI";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.Location = new System.Drawing.Point(18, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Update Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(155, 68);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(405, 24);
            this.cmbStatus.TabIndex = 6;
            // 
            // lblKet
            // 
            this.lblKet.AutoSize = true;
            this.lblKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKet.Location = new System.Drawing.Point(18, 102);
            this.lblKet.Name = "lblKet";
            this.lblKet.Size = new System.Drawing.Size(99, 20);
            this.lblKet.TabIndex = 5;
            this.lblKet.Text = "Keterangan:";
            // 
            // txtKet
            // 
            this.txtKet.Location = new System.Drawing.Point(155, 102);
            this.txtKet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKet.Multiline = true;
            this.txtKet.Name = "txtKet";
            this.txtKet.Size = new System.Drawing.Size(405, 49);
            this.txtKet.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(22, 166);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnWA
            // 
            this.btnWA.BackColor = System.Drawing.Color.Lime;
            this.btnWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWA.Location = new System.Drawing.Point(155, 166);
            this.btnWA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWA.Name = "btnWA";
            this.btnWA.Size = new System.Drawing.Size(128, 33);
            this.btnWA.TabIndex = 2;
            this.btnWA.Text = "WhatsApp";
            this.btnWA.UseVisualStyleBackColor = false;
            this.btnWA.Click += new System.EventHandler(this.btnWA_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.White;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(432, 166);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(128, 33);
            this.btnKembali.TabIndex = 1;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // dgvProduksi
            // 
            this.dgvProduksi.AllowUserToAddRows = false;
            this.dgvProduksi.ColumnHeadersHeight = 29;
            this.dgvProduksi.Location = new System.Drawing.Point(22, 214);
            this.dgvProduksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduksi.Name = "dgvProduksi";
            this.dgvProduksi.RowHeadersWidth = 51;
            this.dgvProduksi.Size = new System.Drawing.Size(538, 191);
            this.dgvProduksi.TabIndex = 0;
            this.dgvProduksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduksi_CellClick);
            // 
            // DataProduksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(580, 416);
            this.Controls.Add(this.dgvProduksi);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnWA);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtKet);
            this.Controls.Add(this.lblKet);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataProduksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Produksi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblJudul, lblStatus, lblKet;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtKet;
        private System.Windows.Forms.Button btnUpdate, btnWA, btnKembali;
        private System.Windows.Forms.DataGridView dgvProduksi;
    }
}