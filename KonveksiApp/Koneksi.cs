using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KonveksiApp
{
    class Koneksi
    {
        private string connString = "Server=localhost;Database=db_konveksi;Uid=root;Pwd=;";
        private MySqlConnection conn;

        public Koneksi()
        {
            conn = new MySqlConnection(connString);
        }

        public void BukaKoneksi()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void TutupKoneksi()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable AmbilData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                BukaKoneksi();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                TutupKoneksi();
            }
            return dt;
        }

        public int EksekusiCommand(string query)
        {
            int hasil = 0;
            try
            {
                BukaKoneksi();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                hasil = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                TutupKoneksi();
            }
            return hasil;
        }
    }
}