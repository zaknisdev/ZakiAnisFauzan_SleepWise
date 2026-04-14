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
    public partial class FormSleepTracker : Form
    {
        koneksiDB db = new koneksiDB();

        int durasi_menit = 0;
        string jamTidurStr = "";
        string jamBangunStr = "";
        DateTime tanggalTidur;

        public FormSleepTracker()
        {
            InitializeComponent();
        }

        private void HitungDurasiHarian()
        {
            DateTime waktuTidur = dtpTidur.Value;
            DateTime waktuBangun = dtpBangun.Value;

            
            if (waktuBangun < waktuTidur)
            {
                waktuBangun = waktuBangun.AddDays(1);
            }

            TimeSpan selisih = waktuBangun - waktuTidur;
            durasi_menit = (int)selisih.TotalMinutes;

            jamTidurStr = waktuTidur.ToString("HH:mm");
            jamBangunStr = waktuBangun.ToString("HH:mm");

            
            tanggalTidur = dtpTanggal.Value.Date;
        }

        private void SimpanDataHarian()
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    
                    string query = "INSERT INTO tr_log_tidur (id_user, tanggal, jam_tidur, jam_bangun, durasi_menit) " +
                                   "VALUES (@id, @tgl, @tidur, @bangun, @durasi)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", UserSession.UserId);
                    cmd.Parameters.AddWithValue("@tgl", tanggalTidur);
                    cmd.Parameters.AddWithValue("@tidur", jamTidurStr);
                    cmd.Parameters.AddWithValue("@bangun", jamBangunStr);
                    cmd.Parameters.AddWithValue("@durasi", durasi_menit);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("data gagal disimpan ke database: " + ex.Message);
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
