
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace KonveksiApp
{
    public partial class DataPesanan : Form
    {
        // Membuat objek untuk mengakses database.
        Koneksi db = new Koneksi();

        // Menyimpan ID pesanan yang sedang dipilih.
        string idPesanan = "";

        // Konstruktor untuk menyiapkan form Data Pesanan.
        public DataPesanan()
        {
            InitializeComponent();
            LoadCustomer();
            LoadComboBox();
            LoadData();
        }

        // Membersihkan tanda petik dan backslash untuk query SQL.
        private string Esc(string s)
        {
            return (s ?? "").Replace("\\", "\\\\").Replace("'", "''");
        }

        // Mengubah angka menjadi teks SQL dengan format internasional.
        private string Num(decimal d)
        {
            return d.ToString(CultureInfo.InvariantCulture);
        }

        // Mengubah nomor WhatsApp ke format internasional (62).
        private string FormatWA(string no)
        {
            no = (no ?? "").Replace(" ", "").Replace("-", "").Replace("+", "");
            if (no.StartsWith("0")) no = "62" + no.Substring(1);
            return no;
        }

        // Membaca nilai DP atau pelunasan dan memvalidasi input angka.
        private bool BacaUang(TextBox txt, string namaField, out decimal nilai)
        {
            nilai = 0;
            string teks = txt.Text.Trim().Replace(".", "").Replace(",", "");
            if (teks == "") return true;

            // Memastikan nilai yang dimasukkan berupa angka.
            if (!decimal.TryParse(teks, NumberStyles.None, CultureInfo.InvariantCulture, out nilai))
            {
                MessageBox.Show(namaField + " harus berupa angka!");
                return false;
            }
            return true;
        }

        // Mengambil jumlah, harga satuan, DP, dan pelunasan.
        private bool AmbilAngka(out int jumlah, out decimal hargaSatuan, out decimal dp, out decimal pelunasan)
        {
            jumlah = 0;
            hargaSatuan = 0;
            dp = 0;
            pelunasan = 0;

            // Memvalidasi jumlah pesanan harus lebih dari nol.
            if (!int.TryParse(txtJumlah.Text.Trim(), out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus berupa angka lebih dari 0!");
                return false;
            }

            // Memvalidasi harga satuan yang dipilih.
            if (!decimal.TryParse(cmbHargaSatuan.SelectedItem.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out hargaSatuan))
            {
                MessageBox.Show("Harga satuan tidak valid!");
                return false;
            }

            // Membaca dan memvalidasi nilai DP serta pelunasan.
            if (!BacaUang(txtDP, "DP", out dp)) return false;
            if (!BacaUang(txtPelunasan, "Pelunasan", out pelunasan)) return false;

            // Memastikan DP dan pelunasan tidak melebihi total harga.
            if (dp + pelunasan > hargaSatuan * jumlah)
            {
                MessageBox.Show("DP + Pelunasan tidak boleh melebihi harga total!");
                return false;
            }

            return true;
        }

        // Mengambil data customer untuk ditampilkan pada ComboBox.
        private void LoadCustomer()
        {
            DataTable dt = db.AmbilData("SELECT id_customer, nama_customer FROM customer");
            cmbCustomer.DataSource = dt;
            cmbCustomer.DisplayMember = "nama_customer";
            cmbCustomer.ValueMember = "id_customer";
            cmbCustomer.SelectedIndex = -1;
        }

        // Mengisi pilihan ukuran, warna, bahan, sablon, dan harga.
        private void LoadComboBox()
        {
            cmbUkuran.Items.Clear();
            cmbWarna.Items.Clear();
            cmbBahan.Items.Clear();
            cmbSablon.Items.Clear();
            cmbHargaSatuan.Items.Clear();

            // Menentukan pilihan ukuran pakaian.
            cmbUkuran.Items.AddRange(new string[] { "S", "M", "L", "XL", "XXL", "XXXL" });

            // Menentukan pilihan warna pakaian.
            cmbWarna.Items.AddRange(new string[] { "Merah", "Biru", "Hijau", "Kuning", "Hitam", "Putih", "Abu-abu", "Navy", "Maroon", "Orange" });

            // Menentukan pilihan jenis bahan pakaian.
            cmbBahan.Items.AddRange(new string[] { "Katun", "Polyester", "TC (Tetoron Cotton)", "CVC", "Spandex", "Denim", "Flanel", "Fleece" });

            // Menentukan pilihan sablon atau bordir.
            cmbSablon.Items.AddRange(new string[] { "Sablon", "Bordir", "Tidak Ada" });

            // Menentukan pilihan harga satuan.
            cmbHargaSatuan.Items.AddRange(new string[] { "35000", "40000", "45000", "50000", "55000", "60000", "65000", "70000", "75000", "80000", "85000", "90000", "95000", "100000" });
        }

        // Mengambil dan menampilkan seluruh data pesanan.
        private void LoadData()
        {
            string q = "SELECT p.id_pesanan, c.nama_customer AS Customer, p.jenis_pakaian AS Jenis, p.jumlah AS Jml, p.harga_total AS Total, p.status_pembayaran AS Status FROM pesanan p JOIN customer c ON p.id_customer = c.id_customer ORDER BY p.id_pesanan DESC";
            dgvPesanan.DataSource = db.AmbilData(q);

            // Menyembunyikan kolom ID pesanan pada tabel.
            if (dgvPesanan.Columns.Count > 0) dgvPesanan.Columns["id_pesanan"].Visible = false;
        }

        // Menghitung total harga dan sisa pembayaran.
        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Memastikan harga satuan dan jumlah sudah diisi.
            if (cmbHargaSatuan.SelectedIndex == -1 || txtJumlah.Text.Trim() == "")
            {
                MessageBox.Show("Pilih Harga Satuan dan isi Jumlah!");
                return;
            }

            // Mengambil dan memvalidasi seluruh nilai angka.
            int jumlah;
            decimal hargaSatuan, dp, pelunasan;
            if (!AmbilAngka(out jumlah, out hargaSatuan, out dp, out pelunasan)) return;

            // Menghitung total harga dan sisa pembayaran.
            decimal total = hargaSatuan * jumlah;
            txtHargaTotal.Text = total.ToString("N0");
            txtSisa.Text = (total - dp - pelunasan).ToString("N0");
        }

        // Menyimpan pesanan baru atau memperbarui pesanan yang dipilih.
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Memastikan seluruh data pesanan wajib sudah diisi.
            if (cmbCustomer.SelectedIndex == -1 || txtJenis.Text.Trim() == "" || txtJumlah.Text.Trim() == "" || cmbUkuran.SelectedIndex == -1 || cmbWarna.SelectedIndex == -1 || cmbBahan.SelectedIndex == -1 || cmbSablon.SelectedIndex == -1 || cmbHargaSatuan.SelectedIndex == -1)
            {
                MessageBox.Show("Lengkapi semua data pesanan!");
                return;
            }

            // Mengambil dan memvalidasi nilai pesanan.
            int jumlah;
            decimal hargaSatuan, dp, pelunasan;
            if (!AmbilAngka(out jumlah, out hargaSatuan, out dp, out pelunasan)) return;

            // Menghitung total, sisa pembayaran, dan status pembayaran.
            decimal total = hargaSatuan * jumlah;
            decimal sisa = total - dp - pelunasan;
            string status = sisa <= 0 ? "Lunas" : "Belum Lunas";
            string deadline = dtpDeadline.Value.ToString("yyyy-MM-dd");

            try
            {
                // Memeriksa apakah pesanan merupakan data baru.
                if (idPesanan == "")
                {
                    // Membuat query untuk menyimpan pesanan baru.
                    string q1 = "INSERT INTO pesanan (id_customer, jenis_pakaian, jumlah, ukuran, warna, bahan, sablon_bordir, deadline, harga_satuan, harga_total, dp, pelunasan, sisa_pembayaran, status_pembayaran) VALUES (" +
                        Convert.ToInt32(cmbCustomer.SelectedValue) + ", '" + Esc(txtJenis.Text.Trim()) + "', " + jumlah + ", '" +
                        Esc(cmbUkuran.SelectedItem.ToString()) + "', '" + Esc(cmbWarna.SelectedItem.ToString()) + "', '" +
                        Esc(cmbBahan.SelectedItem.ToString()) + "', '" + Esc(cmbSablon.SelectedItem.ToString()) + "', '" +
                        deadline + "', " + Num(hargaSatuan) + ", " + Num(total) + ", " + Num(dp) + ", " + Num(pelunasan) + ", " + Num(sisa) + ", '" + status + "')";

                    // Menjalankan proses penyimpanan pesanan.
                    int hasil = db.EksekusiCommand(q1);
                    if (hasil <= 0)
                    {
                        MessageBox.Show("Pesanan gagal disimpan!");
                        return;
                    }

                    // Mengambil ID pesanan yang baru saja dibuat.
                    DataTable dt = db.AmbilData("SELECT LAST_INSERT_ID()");
                    string idBaru = dt.Rows[0][0].ToString();

                    // Memastikan ID pesanan berhasil diperoleh.
                    if (idBaru == "0" || idBaru == "")
                    {
                        MessageBox.Show("Pesanan tersimpan, tetapi ID pesanan tidak terbaca. Data produksi tidak dibuat.");
                        return;
                    }

                    // Membuat data produksi awal dengan status Menunggu.
                    db.EksekusiCommand("INSERT INTO produksi (id_pesanan, status_produksi, tanggal_mulai) VALUES (" + idBaru + ", 'Menunggu', CURDATE())");
                    MessageBox.Show("Pesanan & Produksi berhasil dibuat!");
                }
                else
                {
                    // Memperbarui data pesanan yang sudah dipilih.
                    string q2 = "UPDATE pesanan SET id_customer=" + Convert.ToInt32(cmbCustomer.SelectedValue) +
                        ", jenis_pakaian='" + Esc(txtJenis.Text.Trim()) + "', jumlah=" + jumlah +
                        ", ukuran='" + Esc(cmbUkuran.SelectedItem.ToString()) + "', warna='" + Esc(cmbWarna.SelectedItem.ToString()) +
                        "', bahan='" + Esc(cmbBahan.SelectedItem.ToString()) + "', sablon_bordir='" + Esc(cmbSablon.SelectedItem.ToString()) +
                        "', deadline='" + deadline + "', harga_satuan=" + Num(hargaSatuan) + ", harga_total=" + Num(total) +
                        ", dp=" + Num(dp) + ", pelunasan=" + Num(pelunasan) + ", sisa_pembayaran=" + Num(sisa) + ", status_pembayaran='" + status +
                        "' WHERE id_pesanan=" + Convert.ToInt32(idPesanan);
                    db.EksekusiCommand(q2);
                    MessageBox.Show("Pesanan diupdate!");
                }

                // Mengosongkan form dan memperbarui tabel pesanan.
                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan jika proses simpan atau update gagal.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Mengambil data pesanan dari baris tabel yang dipilih untuk diedit.
        private void dgvPesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengabaikan klik pada bagian header tabel.
            if (e.RowIndex < 0) return;

            try
            {
                // Mengambil ID pesanan dari baris yang dipilih.
                DataGridViewRow row = dgvPesanan.Rows[e.RowIndex];
                idPesanan = row.Cells["id_pesanan"].Value.ToString();

                // Mengambil detail pesanan berdasarkan ID.
                DataTable dt = db.AmbilData("SELECT * FROM pesanan WHERE id_pesanan=" + Convert.ToInt32(idPesanan));
                if (dt.Rows.Count == 0) return;
                DataRow r = dt.Rows[0];

                // Mengisi kembali data pesanan ke komponen form.
                cmbCustomer.SelectedValue = r["id_customer"];
                txtJenis.Text = r["jenis_pakaian"].ToString();
                txtJumlah.Text = r["jumlah"].ToString();
                cmbUkuran.SelectedItem = r["ukuran"].ToString();
                cmbWarna.SelectedItem = r["warna"].ToString();
                cmbBahan.SelectedItem = r["bahan"].ToString();
                cmbSablon.SelectedItem = r["sablon_bordir"].ToString();

                // Mengatur tanggal deadline jika tersedia.
                if (r["deadline"] != DBNull.Value)
                    dtpDeadline.Value = Convert.ToDateTime(r["deadline"]);

                // Mengambil nilai harga dan pembayaran dari database.
                decimal hargaSatuan = r["harga_satuan"] == DBNull.Value ? 0 : Convert.ToDecimal(r["harga_satuan"]);
                decimal total = r["harga_total"] == DBNull.Value ? 0 : Convert.ToDecimal(r["harga_total"]);
                decimal dp = r["dp"] == DBNull.Value ? 0 : Convert.ToDecimal(r["dp"]);
                decimal pelunasan = r["pelunasan"] == DBNull.Value ? 0 : Convert.ToDecimal(r["pelunasan"]);
                decimal sisa = r["sisa_pembayaran"] == DBNull.Value ? 0 : Convert.ToDecimal(r["sisa_pembayaran"]);

                // Menampilkan kembali harga dan pembayaran pada form.
                cmbHargaSatuan.SelectedItem = ((long)hargaSatuan).ToString();
                txtHargaTotal.Text = total.ToString("N0");
                txtDP.Text = ((long)dp).ToString();
                txtPelunasan.Text = ((long)pelunasan).ToString();
                txtSisa.Text = sisa.ToString("N0");
            }
            catch (Exception ex)
            {
                // Menampilkan pesan jika data pesanan gagal dimuat.
                MessageBox.Show("Error memuat data pesanan: " + ex.Message);
            }
        }

        // Mengirim informasi pesanan kepada customer melalui WhatsApp.
        private void btnWA_Click(object sender, EventArgs e)
        {
            // Memastikan pesanan sudah dipilih dari tabel.
            if (idPesanan == "")
            {
                MessageBox.Show("Pilih pesanan di tabel dulu!");
                return;
            }

            try
            {
                // Mengambil informasi customer dan detail pembayaran.
                DataTable dt = db.AmbilData("SELECT c.nama_customer, c.no_whatsapp, p.jenis_pakaian, p.jumlah, p.harga_total, p.sisa_pembayaran FROM pesanan p JOIN customer c ON p.id_customer = c.id_customer WHERE p.id_pesanan=" + Convert.ToInt32(idPesanan));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data pesanan tidak ditemukan!");
                    return;
                }

                // Menyusun pesan WhatsApp berdasarkan detail pesanan.
                DataRow r = dt.Rows[0];
                string pesan = "Halo " + r["nama_customer"].ToString() +
                    ", detail pesanan " + r["jenis_pakaian"].ToString() +
                    " (Jml: " + r["jumlah"].ToString() + "). Total: Rp " + Convert.ToDecimal(r["harga_total"]).ToString("N0") +
                    ". Sisa: Rp " + Convert.ToDecimal(r["sisa_pembayaran"]).ToString("N0") + ". Terima kasih!";

                // Mengubah nomor WhatsApp ke format internasional.
                string nomor = FormatWA(r["no_whatsapp"].ToString());

                // Membuka WhatsApp dengan pesan yang sudah disiapkan.
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

        // Mengosongkan seluruh input pada form.
        private void btnReset_Click(object sender, EventArgs e) { ResetForm(); }

        // Menutup form Data Pesanan.
        private void btnKembali_Click(object sender, EventArgs e) { this.Close(); }

        // Mengembalikan form ke kondisi awal.
        private void ResetForm()
        {
            idPesanan = "";
            cmbCustomer.SelectedIndex = -1;
            txtJenis.Clear();
            txtJumlah.Clear();
            cmbUkuran.SelectedIndex = -1;
            cmbWarna.SelectedIndex = -1;
            cmbBahan.SelectedIndex = -1;
            cmbSablon.SelectedIndex = -1;
            cmbHargaSatuan.SelectedIndex = -1;
            txtHargaTotal.Clear();
            txtDP.Clear();
            txtPelunasan.Clear();
            txtSisa.Clear();
            dtpDeadline.Value = DateTime.Now;
        }

        // Event yang dijalankan saat form Data Pesanan dibuka.
        private void DataPesanan_Load(object sender, EventArgs e)
        {

        }

        // Event saat konten sel tabel diklik.
        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
