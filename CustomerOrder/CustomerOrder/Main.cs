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
    public partial class Main : Form
    {
        public static bool isCompanyNeedingUpdate = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //upon load check if user is logged in, if no display login
            if (!UserDetails.isLoggedIn)
            {
                Login loginForm = new Login();
                this.Hide();
                loginForm.ShowDialog();
                this.Text = this.Text + " - " + UserDetails.Username;
                this.Show();

                Main_Load_Combobox(this.combo_Company);
            }
        }

        private void Main_Load_Combobox(ComboBox comboBox)
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
                data_CustomerSelect.Dispose();
                data_CustomerSelect.Clear();
                DataSet ds = data_CustomerSelect;
                da.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Columns["CustomerName"].Table.Rows.Count; i++)
                {
                    combo_Company.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                }

                Connection.CloseConnection();
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            ApplicationSettings.CloseApplication();
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

                foreach(DataRow item in ds.Tables[0].Columns["PackageName"].Table.Rows)
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
                    input_Update.Enabled = true;
                    button_viewUpdates.Enabled = true;
                    button_SendUpdate.Enabled = true;
                } else
                {
                    combo_Package.Text = "";
                    combo_Package.Enabled = false;
                    input_Update.Enabled = false;
                    button_viewUpdates.Enabled = false;
                    button_SendUpdate.Enabled = false;
                }
                Connection.CloseConnection();
            }
        }

        private void button_SendUpdate_Click(object sender, EventArgs e)
        {
            string input = input_Update.Text;

            //open connection
            Connection.OpenConnection();

            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand customerPackageSelectCommand = Connection.ConnectionDatabase.CreateCommand();

                customerPackageSelectCommand.CommandType = CommandType.StoredProcedure;
                customerPackageSelectCommand.CommandText = "dbo.sp_AddUpdate";
                customerPackageSelectCommand.Parameters.AddWithValue("@CustomerName", combo_Company.SelectedItem);
                customerPackageSelectCommand.Parameters.AddWithValue("@PackageName", combo_Package.SelectedItem);
                customerPackageSelectCommand.Parameters.AddWithValue("@UpdateInput", input);
                customerPackageSelectCommand.Parameters.AddWithValue("@UpdateUser", UserDetails.Username);
                
                customerPackageSelectCommand.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(customerPackageSelectCommand);

                DataSet ds = data_AddUpdate;
                da.Fill(ds);

                //clear input
                input_Update.Text = "";

                //close connection
                Connection.CloseConnection();
            }
        }

        private void button_viewUpdates_Click(object sender, EventArgs e)
        {
            //open connection
            Connection.OpenConnection();

            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand customerPackageSelectCommand = Connection.ConnectionDatabase.CreateCommand();

                customerPackageSelectCommand.CommandType = CommandType.StoredProcedure;
                customerPackageSelectCommand.CommandText = "dbo.sp_ViewUpdate";
                customerPackageSelectCommand.Parameters.AddWithValue("@CustomerName", combo_Company.SelectedItem);
                customerPackageSelectCommand.Parameters.AddWithValue("@PackageName", combo_Package.SelectedItem);

                customerPackageSelectCommand.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(customerPackageSelectCommand);

                DataSet ds = data_AddUpdate;
                da.Fill(ds);

                foreach (DataRow item in ds.Tables[0].Columns["updateUser"].Table.Rows)
                {
                    Updates.UpdateInputs.Add(item.ItemArray[0]);
                    Updates.Users.Add(item.ItemArray[1]);
                }

                Connection.CloseConnection();
                //show update form
                Update updateForm = new Update();
                this.Hide();
                updateForm.ShowDialog();
                this.Show();
                Main_CheckForUpdates();
            }
        }

        private void Main_CheckForUpdates()
        {
            if (isCompanyNeedingUpdate)
            {
                combo_Company.Text = "";
                combo_Company.Items.Clear();
                Main_Load_Combobox(combo_Company);
            }
        }

        private void button_AddCompany_Click(object sender, EventArgs e)
        {
            AddCustomer addCompanyForm = new AddCustomer();
            this.Hide();
            addCompanyForm.ShowDialog();
            this.Show();
            Main_CheckForUpdates();
        }

        private void button_AddPackage_Click(object sender, EventArgs e)
        {
            AddCustomerPackage addPackageForm = new AddCustomerPackage();
            this.Hide();
            addPackageForm.ShowDialog();
            this.Show();
            Main_CheckForUpdates();
        }

        private void button_RemoveCompany_Click(object sender, EventArgs e)
        {
            RemoveCustomer removeCompanyForm = new RemoveCustomer();
            this.Hide();
            removeCompanyForm.ShowDialog();
            this.Show();
            Main_CheckForUpdates();
        }

        private void button_RemovePackage_Click(object sender, EventArgs e)
        {
            RemoveCustomerPackage removePackageForm = new RemoveCustomerPackage();
            this.Hide();
            removePackageForm.ShowDialog();
            this.Show();
            Main_CheckForUpdates();
        }

        private void button_RemovePackage_Click_1(object sender, EventArgs e)
        {
            RemovePackage removePackageForm = new RemovePackage();
            this.Hide();
            removePackageForm.ShowDialog();
            this.Show();
            Main_CheckForUpdates();
        }
    }
}
