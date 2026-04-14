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
    public partial class FormLogin : Form
    {
        koneksiDB db = new koneksiDB();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open(); 
                    MessageBox.Show("Koneksi Aman!");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Koneksi Gagal: " + ex.Message);
                }
            }
        }
    }
}
