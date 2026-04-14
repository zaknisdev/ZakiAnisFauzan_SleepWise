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
    
    public partial class FormSignUp : Form
    {
        koneksiDB db = new koneksiDB();
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtNamaLengkap.Text == "")
            {
                MessageBox.Show("Diisi semua ya ganteng!");
                return; 
            }

            
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    
                    string query = "INSERT INTO ms_user (username, password, nama_lengkap, role, target_tidur_jam) " +
                                   "VALUES (@user, @pass, @nama, 'Pengguna', 8)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text);

                    
                    int hasil = cmd.ExecuteNonQuery();

                    if (hasil > 0)
                    {
                        MessageBox.Show("Akun berhasil dibuat! Silakan login dengan akun baru Anda.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormLogin formLogin = new FormLogin();
                        formLogin.Show();
                        this.Hide();
                    }
                }
                catch (MySqlException ex)
                {
                    
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Username sudah dipakai orang lain! Jangan nyontek orang lain beb!");
                    }
                    else
                    {
                        MessageBox.Show("Gagal nyambung ke database: " + ex.Message);
                    }
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
    
}
