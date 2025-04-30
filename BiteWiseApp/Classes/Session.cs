using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteWiseApp.Classes
{
    public static class Session
    {
        public static int LoggedInUserId { get; set; }
        public static string LoggedInUserEmail { get; set; }
        // You can add more if you need later (e.g., user name, role, etc.)
    }
}
