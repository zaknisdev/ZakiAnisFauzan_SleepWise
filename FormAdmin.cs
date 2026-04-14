using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SleepWise
{
    public partial class FormAdmin : Form
    {
        koneksiDB db = new koneksiDB();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void LoadDataPengguna()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    
                    string query = "SELECT id_user, username, nama_lengkap, role, target_tidur_jam FROM ms_user";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAdmin.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal tarik data pengguna lee: " + ex.Message);
                }
            }
        }

        private void btnDataPengguna_Click(object sender, EventArgs e)
        {
            LoadDataPengguna();
        }

        private void btnDataLog_Click(object sender, EventArgs e)
        {

        }

        private void btnHapusPengguna_Click(object sender, EventArgs e)
        {
            HapusPengguna();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.ClearSession();

            MessageBox.Show("Berhasil Logout!");
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void HapusPengguna()
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                int idUserTerpilih = Convert.ToInt32(dgvAdmin.SelectedRows[0].Cells["id_user"].Value);
                string namaUser = dgvAdmin.SelectedRows[0].Cells["username"].Value.ToString();

               
                DialogResult dialogResult = MessageBox.Show($"Yakin mau menghapus user '{namaUser}'?\nSemua data yang berhubungan dengan user ikut dihapus!", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection conn = db.GetConnection())
                    {
                        try
                        {
                            conn.Open();
                            
                            string query = "DELETE FROM ms_user WHERE id_user = @id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", idUserTerpilih);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("pengguna berhasil dihapus!");

                            
                            LoadDataPengguna();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Gagal menghapus pengguna: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Data yang mau dihapus belum dipilih!");
            }
        }

        private void UpdateSaran()
        {
            // Validasi: Pastikan textbox nggak kosong
            if (txtIdKategori.Text == "" || txtSaranBaru.Text == "")
            {
                MessageBox.Show("Isi dulu ID Kategori dan Saran barunya Bang!", "Peringatan");
                return;
            }

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    
                    string query = "UPDATE ms_kategori_tidur SET saran_harian = @saranBaru WHERE id_kategori = @idKategori";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@saranBaru", txtSaranBaru.Text);
                    cmd.Parameters.AddWithValue("@idKategori", Convert.ToInt32(txtIdKategori.Text));

                    int hasil = cmd.ExecuteNonQuery();

                    if (hasil > 0)
                    {
                        MessageBox.Show("Saran harian berhasil di-update!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdKategori.Clear();
                        txtSaranBaru.Clear();
                    }
                    else
                    {
                        MessageBox.Show("ID Kategori tidak ditemukan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update saran: " + ex.Message);
                }
            }
        }

        private void btnUpdateSaran_Click(object sender, EventArgs e)
        {
            UpdateSaran();
        }
    }
}
