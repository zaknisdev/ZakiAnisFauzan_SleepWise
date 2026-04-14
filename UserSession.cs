using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepWise
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static int TargetTidur { get; set; }

        public static void ClearSession()
        {
            UserId = 0;
            Username = null;
            Role = null;
            TargetTidur = 0;
        }
    }
}
