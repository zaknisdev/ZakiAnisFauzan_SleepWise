using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SleepWise
{
    public class koneksiDB
    {
        static string connectionString = string.Format("Server=localhost;database=SleepWiseDB;UID=root;" + "Password=andasiapa");
        
        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
           
            
        }

    }
}
