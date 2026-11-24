
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace KonveksiApp
{
    public partial class Laporan : Form
    {
        // Membuat objek untuk mengakses database.
        Koneksi db = new Koneksi();

        // Konstruktor untuk menampilkan form Laporan.
        public Laporan()
        {
            InitializeComponent();
        }

        // Menampilkan data pesanan customer.
        private void btnLapPesanan_Click(object sender, EventArgs e)
        {
            lblJudul.Text = "LAPORAN PESANAN";

            // Mengambil data pesanan beserta nama customer dari database.
            dgvLaporan.DataSource = db.AmbilData("SELECT p.id_pesanan, c.nama_customer AS Customer, p.jenis_pakaian AS Jenis, p.jumlah AS Jml, p.harga_total AS Total, p.status_pembayaran AS Status, p.tanggal_pesanan AS Tanggal FROM pesanan p JOIN customer c ON p.id_customer = c.id_customer ORDER BY p.tanggal_pesanan DESC");
        }

        // Menampilkan data perkembangan produksi.
        private void btnLapProduksi_Click(object sender, EventArgs e)
        {
            lblJudul.Text = "LAPORAN PRODUKSI";

            // Mengambil data pesanan, customer, dan status produksi.
            dgvLaporan.DataSource = db.AmbilData("SELECT c.nama_customer AS Customer, p.jenis_pakaian AS Pesanan, pr.status_produksi AS Status, pr.tanggal_mulai AS Mulai, pr.tanggal_selesai AS Selesai FROM produksi pr JOIN pesanan p ON pr.id_pesanan = p.id_pesanan JOIN customer c ON p.id_customer = c.id_customer");
        }

        // Menampilkan laporan pembayaran dan menghitung total pembayaran.
        private void btnLapPembayaran_Click(object sender, EventArgs e)
        {
            lblJudul.Text = "LAPORAN PEMBAYARAN";

            // Mengambil data total harga, DP, sisa pembayaran, dan status.
            DataTable dt = db.AmbilData("SELECT c.nama_customer AS Customer, p.jenis_pakaian AS Pesanan, p.harga_total AS Total, p.dp AS DP, p.sisa_pembayaran AS Sisa, p.status_pembayaran AS Status FROM pesanan p JOIN customer c ON p.id_customer = c.id_customer");
            dgvLaporan.DataSource = dt;

            // Menyiapkan variabel untuk menyimpan hasil perhitungan.
            decimal total = 0, dp = 0, sisa = 0;

            // Menjumlahkan total harga, DP, dan sisa pembayaran.
            foreach (DataRow row in dt.Rows)
            {
                total += Convert.ToDecimal(row["Total"]);
                dp += Convert.ToDecimal(row["DP"]);
                sisa += Convert.ToDecimal(row["Sisa"]);
            }

            // Menampilkan ringkasan hasil perhitungan pembayaran.
            lblTotal.Text = "Total Pendapatan: Rp " + total.ToString("N0") + " | Total DP: Rp " + dp.ToString("N0") + " | Total Sisa: Rp " + sisa.ToString("N0");
        }

        // Mengekspor data laporan ke dalam format CSV.
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah tabel memiliki data.
            if (dgvLaporan.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data!");
                return;
            }

            // Membuka dialog untuk menentukan lokasi penyimpanan file.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";
            sfd.FileName = "Laporan_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Menyiapkan variabel untuk menyimpan isi file CSV.
                string csv = "";

                // Mengambil nama kolom sebagai header CSV.
                for (int i = 0; i < dgvLaporan.Columns.Count; i++)
                {
                    csv += dgvLaporan.Columns[i].HeaderText;
                    if (i < dgvLaporan.Columns.Count - 1) csv += ",";
                }
                csv += "\n";

                // Mengambil seluruh isi baris dan kolom dari tabel.
                for (int i = 0; i < dgvLaporan.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvLaporan.Columns.Count; j++)
                    {
                        // Mengambil nilai sel dan mengganti koma agar format CSV tetap terjaga.
                        string val = dgvLaporan.Rows[i].Cells[j].Value != null ? dgvLaporan.Rows[i].Cells[j].Value.ToString().Replace(",", " ") : "";
                        csv += val;
                        if (j < dgvLaporan.Columns.Count - 1) csv += ",";
                    }
                    csv += "\n";
                }

                // Menyimpan data laporan ke file CSV.
                File.WriteAllText(sfd.FileName, csv);
                MessageBox.Show("Export Berhasil!");
            }
        }

        // Menutup form Laporan dan kembali ke form sebelumnya.
        private void btnKembali_Click(object sender, EventArgs e) { this.Close(); }

        // Event yang dijalankan saat form Laporan dibuka.
        private void Laporan_Load(object sender, EventArgs e)
        {

        }
    }
}
