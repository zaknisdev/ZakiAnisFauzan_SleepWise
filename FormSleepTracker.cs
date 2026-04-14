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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
