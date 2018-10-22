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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AddCompany_Click(object sender, EventArgs e)
        {
            if (input_CustomerName.Text.Length > 0)
            {
                // open connection
                Connection.OpenConnection();

                if (Connection.ConnectionDatabase.State == ConnectionState.Open)
                {
                    SqlCommand customerPackageSelectCommand = Connection.ConnectionDatabase.CreateCommand();

                    customerPackageSelectCommand.CommandType = CommandType.StoredProcedure;
                    customerPackageSelectCommand.CommandText = "dbo.sp_AddCustomer";
                    customerPackageSelectCommand.Parameters.AddWithValue("@CustomerName", input_CustomerName.Text);

                    customerPackageSelectCommand.CommandTimeout = Connection.ConnectionTimeout;
                    SqlDataAdapter da = new SqlDataAdapter(customerPackageSelectCommand);

                    DataSet ds = data_AddCustomer;
                    da.Fill(ds);

                    input_CustomerName.Text = "";

                    Connection.CloseConnection();

                    Main.isCompanyNeedingUpdate = true;

                    this.Close();
                }
            } else
            {
                MessageBox.Show("Customer name can not be blank");
            }
        }
    }
}
