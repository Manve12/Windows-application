using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustomerOrder
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            ApplicationSettings.CloseApplication();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //open connection
            Connection.OpenConnection();
            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand cmd = Connection.ConnectionDatabase.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.sp_LoginSelect";
                cmd.Parameters.AddWithValue("@Username", input_Username.Text);
                cmd.Parameters.AddWithValue("@Password", input_Password.Text);
                cmd.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = data_Login;
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0) // data found for login
                {
                    var user = ds.Tables[0].Columns["AccountUsername"].Table.Rows[0].ItemArray[0].ToString();
                    
                    UserDetails.Username = user;
                    UserDetails.isLoggedIn = true;
                    this.Close();
                }

                //close connection
                Connection.CloseConnection();
            }
            
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
