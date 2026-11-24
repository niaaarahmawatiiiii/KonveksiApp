
using System;
using System.Data;
using System.Windows.Forms;

namespace KonveksiApp
{
    public partial class DataProduksi : Form
    {
        // Membuat objek untuk mengakses database.
        Koneksi db = new Koneksi();

        // Menyimpan ID produksi yang dipilih.
        string idProduksi = "";

        // Konstruktor untuk menyiapkan form Data Produksi.
        public DataProduksi()
        {
            InitializeComponent();
            LoadComboBox();
            LoadData();
        }

        // Membersihkan tanda petik dan backslash untuk query SQL.
        private string Esc(string s)
        {
            return (s ?? "").Replace("\\", "\\\\").Replace("'", "''");
        }

        // Mengubah nomor WhatsApp ke format internasional (62).
        private string FormatWA(string no)
        {
            no = (no ?? "").Replace(" ", "").Replace("-", "").Replace("+", "");
            if (no.StartsWith("0")) no = "62" + no.Substring(1);
            return no;
        }

        // Mengisi ComboBox dengan pilihan status produksi.
        private void LoadComboBox()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Menunggu", "Dipotong", "Dijahit", "Sablon/Bordir", "Finishing", "Selesai" });
        }

        // Mengambil dan menampilkan data produksi dari database.
        private void LoadData()
        {
            string q = "SELECT pr.id_produksi, c.nama_customer AS Customer, p.jenis_pakaian AS Pesanan, pr.status_produksi AS Status, pr.keterangan AS Ket FROM produksi pr JOIN pesanan p ON pr.id_pesanan = p.id_pesanan JOIN customer c ON p.id_customer = c.id_customer ORDER BY pr.id_produksi DESC";
            dgvProduksi.DataSource = db.AmbilData(q);

            // Menyembunyikan kolom ID produksi pada tabel.
            if (dgvProduksi.Columns.Count > 0) dgvProduksi.Columns["id_produksi"].Visible = false;
        }

        // Memperbarui status dan keterangan produksi.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Memastikan data dan status produksi sudah dipilih.
            if (idProduksi == "" || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih data dan status!");
                return;
            }

            try
            {
                // Mengambil status yang dipilih dan mengatur tanggal selesai.
                string status = cmbStatus.SelectedItem.ToString();
                string tgl = status == "Selesai" ? "CURDATE()" : "NULL";

                // Memperbarui status, tanggal selesai, dan keterangan produksi.
                db.EksekusiCommand("UPDATE produksi SET status_produksi='" + Esc(status) +
                    "', tanggal_selesai=" + tgl +
                    ", keterangan='" + Esc(txtKet.Text.Trim()) +
                    "' WHERE id_produksi=" + Convert.ToInt32(idProduksi));

                MessageBox.Show("Status produksi diupdate!");

                // Memuat ulang data dan mengosongkan form.
                LoadData();
                ResetForm();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan jika proses update gagal.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Mengirim informasi status produksi melalui WhatsApp.
        private void btnWA_Click(object sender, EventArgs e)
        {
            // Memastikan data produksi sudah dipilih.
            if (idProduksi == "")
            {
                MessageBox.Show("Pilih data di tabel dulu!");
                return;
            }

            try
            {
                // Mengambil informasi customer dan produksi dari database.
                DataTable dt = db.AmbilData("SELECT c.nama_customer, c.no_whatsapp, p.jenis_pakaian, pr.status_produksi FROM produksi pr JOIN pesanan p ON pr.id_pesanan = p.id_pesanan JOIN customer c ON p.id_customer = c.id_customer WHERE pr.id_produksi=" + Convert.ToInt32(idProduksi));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data produksi tidak ditemukan!");
                    return;
                }

                // Menyusun pesan berdasarkan data produksi.
                DataRow r = dt.Rows[0];
                string pesan = "Halo " + r["nama_customer"].ToString() +
                    ", update produksi " + r["jenis_pakaian"].ToString() +
                    ". Status saat ini: " + r["status_produksi"].ToString() + ". Terima kasih!";

                // Mengubah nomor WhatsApp ke format internasional.
                string nomor = FormatWA(r["no_whatsapp"].ToString());

                // Membuka WhatsApp melalui browser dengan pesan otomatis.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://wa.me/" + nomor + "?text=" + Uri.EscapeDataString(pesan),
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Menampilkan pesan jika WhatsApp gagal dibuka.
                MessageBox.Show("Gagal membuka WhatsApp: " + ex.Message);
            }
        }

        // Mengambil data dari baris tabel yang dipilih.
        private void dgvProduksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengabaikan klik pada bagian header tabel.
            if (e.RowIndex < 0) return;

            // Mengisi form berdasarkan data produksi yang dipilih.
            DataGridViewRow row = dgvProduksi.Rows[e.RowIndex];
            idProduksi = row.Cells["id_produksi"].Value.ToString();
            cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            txtKet.Text = row.Cells["Ket"].Value == null ? "" : row.Cells["Ket"].Value.ToString();
        }

        // Menutup form Data Produksi.
        private void btnKembali_Click(object sender, EventArgs e) { this.Close(); }

        // Mengosongkan pilihan dan input pada form.
        private void ResetForm()
        {
            idProduksi = "";
            cmbStatus.SelectedIndex = -1;
            txtKet.Clear();
        }
    }
}