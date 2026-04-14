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
    }
}
