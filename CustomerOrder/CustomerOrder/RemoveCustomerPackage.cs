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
    public partial class RemoveCustomerPackage : Form
    {
        public RemoveCustomerPackage()
        {
            InitializeComponent();
        }

        private void RemovePackage_Load(object sender, EventArgs e)
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

        private void combo_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            //open connection
            Connection.OpenConnection();

            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand customerPackageSelectCommand = Connection.ConnectionDatabase.CreateCommand();

                customerPackageSelectCommand.CommandType = CommandType.StoredProcedure;
                customerPackageSelectCommand.CommandText = "dbo.sp_SelectCustomerPackages";
                customerPackageSelectCommand.Parameters.AddWithValue("@CustomerName", combo_Company.SelectedItem);
                customerPackageSelectCommand.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(customerPackageSelectCommand);
                data_CustomerPackageSelect.Dispose();
                data_CustomerPackageSelect.Clear();

                if (data_CustomerPackageSelect.Tables.Count > 0)
                {
                    data_CustomerPackageSelect.Tables.RemoveAt(0);
                }

                DataSet ds = data_CustomerPackageSelect;

                da.Fill(ds);

                combo_Package.Items.Clear();

                foreach (DataRow item in ds.Tables[0].Columns["PackageName"].Table.Rows)
                {
                    if (item != null)
                    {
                        combo_Package.Items.Add(item.ItemArray[2]);
                    }
                }

                if (combo_Package.Items.Count > 0)
                {
                    combo_Package.SelectedIndex = 0;
                    combo_Package.Enabled = true;
                }
                else
                {
                    combo_Package.Text = "";
                    combo_Package.Enabled = false;
                }
                Connection.CloseConnection();
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_RemovePackage_Click(object sender, EventArgs e)
        {
            Connection.OpenConnection();

            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand customerPackageSelectCommand = Connection.ConnectionDatabase.CreateCommand();

                customerPackageSelectCommand.CommandType = CommandType.StoredProcedure;
                customerPackageSelectCommand.CommandText = "dbo.sp_RemoveCustomerPackage";
                customerPackageSelectCommand.Parameters.AddWithValue("@CompanyName", combo_Company.SelectedItem);
                customerPackageSelectCommand.Parameters.AddWithValue("@PackageName", combo_Package.SelectedItem);
                customerPackageSelectCommand.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(customerPackageSelectCommand);

                DataSet ds = data_RemoveCustomerPackage;

                da.Fill(ds);

                Connection.CloseConnection();
                Main.isCompanyNeedingUpdate = true;
                this.Close();
            }
        }
    }
}
