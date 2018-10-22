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
    public partial class RemovePackage : Form
    {
        public RemovePackage()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_RemovePackage_Click(object sender, EventArgs e)
        {
            //open connection
            Connection.OpenConnection();

            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand customerSelectCommand = Connection.ConnectionDatabase.CreateCommand();

                customerSelectCommand.CommandType = CommandType.StoredProcedure;
                customerSelectCommand.CommandText = "dbo.sp_RemovePackage";
                customerSelectCommand.Parameters.AddWithValue("@PackageName", combo_Package.SelectedItem);
                customerSelectCommand.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(customerSelectCommand);
                DataSet ds = data_RemovePackage;
                da.Fill(ds);

                Connection.CloseConnection();
                Main.isCompanyNeedingUpdate = true;
                this.Close();
            }
        }

        private void RemovePackage_Load(object sender, EventArgs e)
        {
            //open connection
            Connection.OpenConnection();

            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand customerSelectCommand = Connection.ConnectionDatabase.CreateCommand();

                customerSelectCommand.CommandType = CommandType.StoredProcedure;
                customerSelectCommand.CommandText = "dbo.sp_PackageSelect";
                customerSelectCommand.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(customerSelectCommand);
                DataSet ds = data_RemovePackage;
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Columns["PackageName"].Table.Rows.Count; i++)
                {
                    combo_Package.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                }

                Connection.CloseConnection();
            }
        }
    }
}
