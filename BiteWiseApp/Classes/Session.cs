using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiteWiseApp.Classes;


namespace BiteWiseApp.Classes
{
    public static class Session
    {
        public static int LoggedInUserId { get; set; }

        public static User LoggedInUser { get; set; }
        public static string LoggedInUserEmail { get; set; }

        public static int user_id { get; set; }
        // You can add more if you need later (e.g., user name, role, etc.)
    }
}
