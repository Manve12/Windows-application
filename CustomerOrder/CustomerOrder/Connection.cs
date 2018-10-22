using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder
{
    public static class Connection
    {
        public static string ConnectionString { get; set; } = "Data Source=NM-16010-PC;Initial Catalog=InventoryManagement;Integrated Security=True";
        public static SqlConnection ConnectionDatabase { get; set; } = new SqlConnection(ConnectionString);

        public static int ConnectionTimeout { get; } = 60;

        public static void OpenConnection()
        {
            ConnectionDatabase.Open();
        }

        public static void CloseConnection()
        {
            ConnectionDatabase.Close();
        }
    }
}
