using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder
{
    public static class Updates
    {
        public static List<object> Users = new List<object>();
        public static List<object> UpdateInputs = new List<object>();

        public static int NumberOfUpdates => Users.Count();
    }
}
