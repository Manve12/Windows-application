using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerOrder
{
    public partial class Register : Form
    {
        private List<string> RegisterErrors = new List<string>();

        public Register()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            ApplicationSettings.CloseApplication();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            AccountValidation.Errors = new List<string>();
            //check details first before adding to database
            if (input_Username.Text.Length < AccountValidation.UsernameMinimumLength)
            {
                AccountValidation.Errors.Add("* Username has to be atleast 6 characters long");
            }

            var p = input_Password;
            var cp = input_ConfirmPassword;

            if (input_Password.Text != input_ConfirmPassword.Text)
            {
                AccountValidation.Errors.Add("* Passwords do not match");
            }

            if (input_Password.Text.Length < AccountValidation.PasswordMinimumLength)
            {
                AccountValidation.Errors.Add("* Password has to be atleast " + AccountValidation.PasswordMinimumLength + " characters long");
            }

            if (AccountValidation.isThereAnyErrors)
            {
                string err = "";
                foreach (var error in AccountValidation.Errors) {
                    err += error;
                }
                MessageBox.Show(err);
                return; 
            }

            //open connection
            Connection.OpenConnection();
            
            if (Connection.ConnectionDatabase.State == ConnectionState.Open)
            {
                SqlCommand cmd = Connection.ConnectionDatabase.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.sp_RegisterCreate";
                cmd.Parameters.AddWithValue("@Username", input_Username.Text);
                cmd.Parameters.AddWithValue("@Password", input_Password.Text);
                cmd.CommandTimeout = Connection.ConnectionTimeout;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = data_Register;
                da.Fill(ds);

                //close connection
                Connection.CloseConnection();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
