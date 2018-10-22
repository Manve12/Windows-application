using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder
{
    public static class UserDetails
    {
        public static bool isLoggedIn { get; set; } = false;

        public static string Username { get; set; }
    }
}
