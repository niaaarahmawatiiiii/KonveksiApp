
using System;
using System.Windows.Forms;
using System.Drawing;

namespace KonveksiApp
{
    public partial class Login : Form
    {
        // Membuat objek untuk mengakses database.
        Koneksi db = new Koneksi();

        // Konstruktor untuk mengatur tampilan awal form Login.
        public Login()
        {
            InitializeComponent();

            // Menyembunyikan password saat form pertama kali dibuka.
            txtPassword.UseSystemPasswordChar = true;

            // Membuat CheckBox untuk fitur Lihat Password.
            CheckBox chkLihatPassword = new CheckBox();

            chkLihatPassword.Name = "chkLihatPassword";
            chkLihatPassword.Text = "Lihat Password";
            chkLihatPassword.AutoSize = true;

            // Menempatkan CheckBox tepat di bawah TextBox Password.
            chkLihatPassword.Location = new Point(
                txtPassword.Left,
                txtPassword.Bottom + 5
            );

            // Mengatur jenis dan ukuran font CheckBox.
            chkLihatPassword.Font = new Font(
                "Microsoft Sans Serif", 9
            );

            // Mengatur fungsi tampil dan sembunyi password.
            chkLihatPassword.CheckedChanged += (s, e) =>
            {
                txtPassword.UseSystemPasswordChar =
                    !chkLihatPassword.Checked;
            };

            // Menambahkan CheckBox ke dalam form Login.
            this.Controls.Add(chkLihatPassword);

            // Menampilkan CheckBox di atas komponen lainnya.
            chkLihatPassword.BringToFront();
        }

        // Memproses username dan password saat tombol Login diklik.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah username dan password sudah diisi.
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan Password harus diisi!");
                return;
            }

            // Membuat query untuk memeriksa data admin.
            string query = "SELECT * FROM admin WHERE username='" +
                          txtUsername.Text + "' AND password='" +
                          txtPassword.Text + "'";
            var dt = db.AmbilData(query);

            // Memeriksa hasil pencarian data admin.
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login berhasil!");

                // Menyembunyikan form Login dan membuka Dashboard.
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                // Menampilkan pesan jika username atau password salah.
                MessageBox.Show("Username atau Password salah!");

                // Mengosongkan password dan mengarahkan fokus ke input password.
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        // Memproses tombol Batal untuk keluar dari aplikasi.
        private void btnBatal_Click(object sender, EventArgs e)
        {
            // Meminta konfirmasi sebelum aplikasi ditutup.
            if (MessageBox.Show("Yakin keluar?", "Konfirmasi",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Event yang dijalankan saat form Login dibuka.
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
