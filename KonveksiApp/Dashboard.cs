using System;
using System.Windows.Forms;

namespace KonveksiApp
{
    public partial class Dashboard : Form
    {
        // Membuat objek untuk mengakses database.
        Koneksi db = new Koneksi();

        // Konstruktor Form Dashboard.
        public Dashboard()
        {
            InitializeComponent();

            // Memuat ulang data setiap Dashboard aktif.
            this.Activated += (s, e) => LoadDashboard();
        }

        // Mengambil dan menampilkan ringkasan data dashboard.
        private void LoadDashboard()
        {
            try
            {
                // Menghitung total seluruh pesanan.
                var dt1 = db.AmbilData("SELECT COUNT(*) as total FROM pesanan");
                if (dt1.Rows.Count > 0)
                    lblTotalPesanan.Text = dt1.Rows[0]["total"].ToString();

                // Menghitung pesanan yang masih dalam proses produksi.
                var dt2 = db.AmbilData("SELECT COUNT(*) as total FROM produksi WHERE status_produksi != 'Selesai'");
                if (dt2.Rows.Count > 0)
                    lblProduksi.Text = dt2.Rows[0]["total"].ToString();

                // Menghitung pesanan yang sudah selesai diproduksi.
                var dt3 = db.AmbilData("SELECT COUNT(*) as total FROM produksi WHERE status_produksi = 'Selesai'");
                if (dt3.Rows.Count > 0)
                    lblSelesai.Text = dt3.Rows[0]["total"].ToString();

                // Menghitung pesanan yang belum lunas pembayarannya.
                var dt4 = db.AmbilData("SELECT COUNT(*) as total FROM pesanan WHERE status_pembayaran = 'Belum Lunas'");
                if (dt4.Rows.Count > 0)
                    lblBelumLunas.Text = dt4.Rows[0]["total"].ToString();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan jika terjadi kesalahan saat memuat data.
                MessageBox.Show("Error memuat dashboard: " + ex.Message);
            }
        }

        // Membuka Form Data Customer.
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            DataCustomer customer = new DataCustomer();
            customer.Show();
        }

        // Membuka Form Data Pesanan.
        private void btnPesanan_Click(object sender, EventArgs e)
        {
            DataPesanan pesanan = new DataPesanan();
            pesanan.Show();
        }

        // Membuka Form Data Produksi.
        private void btnProduksi_Click(object sender, EventArgs e)
        {
            DataProduksi produksi = new DataProduksi();
            produksi.Show();
        }

        // Membuka Form Laporan.
        private void btnLaporan_Click(object sender, EventArgs e)
        {
            Laporan laporan = new Laporan();
            laporan.Show();
        }

        // Memproses logout dan kembali ke Form Login.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin logout?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }
    }
}