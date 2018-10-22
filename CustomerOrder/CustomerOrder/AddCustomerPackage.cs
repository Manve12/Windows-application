using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerOrder
{
    public partial class AddCustomerPackage : Form
    {
        public AddCustomerPackage()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPackage_Load(object sender, EventArgs e)
        {
            //open connection
            Connection.OpenConnection();

            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand customerSelectCommand = Connection.ConnectionDatabase.CreateCommand();

                customerSelectCommand.CommandType = CommandType.StoredProcedure;
                customerSelectCommand.CommandText = "dbo.sp_CustomerSelect";
                customerSelectCommand.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(customerSelectCommand);
                DataSet ds = data_CustomerSelect;
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    combo_Company.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                }

                Connection.CloseConnection();
            }
        }
    }
}
