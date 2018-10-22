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
    public partial class RemoveCustomer : Form
    {
        public RemoveCustomer()
        {
            InitializeComponent();
        }

        private void RemoveCompany_Load(object sender, EventArgs e)
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

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();

            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand customerPackageSelectCommand = Connection.ConnectionDatabase.CreateCommand();

                customerPackageSelectCommand.CommandType = CommandType.StoredProcedure;
                customerPackageSelectCommand.CommandText = "dbo.sp_RemoveCustomer";
                customerPackageSelectCommand.Parameters.AddWithValue("@CustomerName", combo_Company.SelectedItem);
                customerPackageSelectCommand.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(customerPackageSelectCommand);

                DataSet ds = data_RemoveCustomer;

                da.Fill(ds);

                Connection.CloseConnection();
                Main.isCompanyNeedingUpdate = true;
                this.Close();
            }
        }
    }
}
