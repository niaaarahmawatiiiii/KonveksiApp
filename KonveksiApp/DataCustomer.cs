using System;
using System.Data;
using System.Windows.Forms;

namespace KonveksiApp
{
    public partial class DataCustomer : Form
    {
        // Membuat objek untuk mengakses database.
        Koneksi db = new Koneksi();

        // Menyimpan ID customer yang sedang dipilih.
        string idCustomer = "";

        // Konstruktor Form Data Customer.
        public DataCustomer()
        {
            InitializeComponent();

            // Menampilkan data customer saat form dibuka.
            LoadData();
        }

        // Mengambil dan menampilkan data customer dari database.
        private void LoadData()
        {
            dgvCustomer.DataSource = db.AmbilData("SELECT id_customer, nama_customer AS Nama, no_whatsapp AS WhatsApp, alamat AS Alamat FROM customer ORDER BY id_customer DESC");

            // Menyembunyikan kolom ID customer.
            if (dgvCustomer.Columns.Count > 0)
            {
                dgvCustomer.Columns["id_customer"].Visible = false;
            }
        }

        // Menyimpan data customer baru atau memperbarui data yang dipilih.
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah nama dan nomor WhatsApp sudah diisi.
            if (txtNama.Text == "" || txtWA.Text == "")
            {
                MessageBox.Show("Nama dan WhatsApp wajib diisi!");
                return;
            }

            string query;

            // Menambahkan data customer baru jika belum ada ID.
            if (idCustomer == "")
            {
                query = "INSERT INTO customer (nama_customer, no_whatsapp, alamat) VALUES ('" + txtNama.Text + "', '" + txtWA.Text + "', '" + txtAlamat.Text + "')";
            }
            else
            {
                // Memperbarui data customer berdasarkan ID.
                query = "UPDATE customer SET nama_customer='" + txtNama.Text + "', no_whatsapp='" + txtWA.Text + "', alamat='" + txtAlamat.Text + "' WHERE id_customer=" + idCustomer;
            }

            // Menjalankan perintah penyimpanan ke database.
            db.EksekusiCommand(query);

            MessageBox.Show("Data berhasil disimpan!");

            // Mengosongkan form dan memperbarui tabel.
            ResetForm();
            LoadData();
        }

        // Menghapus data customer beserta pesanan dan produksi terkait.
        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Memastikan data customer sudah dipilih.
            if (idCustomer == "")
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            // Meminta konfirmasi sebelum menghapus data.
            if (MessageBox.Show("Yakin hapus customer ini?\nSemua pesanan terkait juga akan dihapus!", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // Menghapus data produksi yang terkait dengan pesanan customer.
                    string q1 = "DELETE FROM produksi WHERE id_pesanan IN (SELECT id_pesanan FROM pesanan WHERE id_customer = " + idCustomer + ")";
                    db.EksekusiCommand(q1);

                    // Menghapus seluruh pesanan milik customer.
                    string q2 = "DELETE FROM pesanan WHERE id_customer = " + idCustomer;
                    db.EksekusiCommand(q2);

                    // Menghapus data customer dari database.
                    string q3 = "DELETE FROM customer WHERE id_customer = " + idCustomer;
                    db.EksekusiCommand(q3);

                    MessageBox.Show("Customer dan semua pesanan terkait berhasil dihapus!");

                    // Mengosongkan form dan memperbarui tabel.
                    ResetForm();
                    LoadData();
                }
                catch (Exception ex)
                {
                    // Menampilkan pesan jika terjadi kesalahan.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Mengosongkan seluruh input pada form.
        private void btnReset_Click(object sender, EventArgs e) { ResetForm(); }

        // Menutup Form Data Customer.
        private void btnKembali_Click(object sender, EventArgs e) { this.Close(); }

        // Mengisi input form berdasarkan baris customer yang dipilih.
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Memastikan baris data yang dipilih valid.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                // Mengambil ID dan mengisi data customer ke input form.
                idCustomer = row.Cells["id_customer"].Value.ToString();
                txtNama.Text = row.Cells["Nama"].Value.ToString();
                txtWA.Text = row.Cells["WhatsApp"].Value.ToString();
                txtAlamat.Text = row.Cells["Alamat"].Value.ToString();
            }
        }

        // Mengatur form kembali ke kondisi awal.
        private void ResetForm()
        {
            idCustomer = "";
            txtNama.Clear();
            txtWA.Clear();
            txtAlamat.Clear();
        }

        // Event ketika label judul diklik.
        private void lblJudul_Click(object sender, EventArgs e)
        {

        }
    }
}