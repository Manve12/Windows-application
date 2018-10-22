namespace CustomerOrder
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.input_Username = new System.Windows.Forms.TextBox();
            this.input_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.data_Login = new CustomerOrder.InventoryManagementDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.data_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Username.Location = new System.Drawing.Point(31, 37);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(83, 20);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Password.Location = new System.Drawing.Point(31, 97);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(78, 20);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // input_Username
            // 
            this.input_Username.Location = new System.Drawing.Point(35, 60);
            this.input_Username.Name = "input_Username";
            this.input_Username.Size = new System.Drawing.Size(205, 20);
            this.input_Username.TabIndex = 2;
            // 
            // input_Password
            // 
            this.input_Password.Location = new System.Drawing.Point(35, 120);
            this.input_Password.Name = "input_Password";
            this.input_Password.Size = new System.Drawing.Size(205, 20);
            this.input_Password.TabIndex = 3;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(34, 162);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(206, 43);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(34, 211);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(100, 27);
            this.button_Register.TabIndex = 5;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(140, 211);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(100, 27);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // data_Login
            // 
            this.data_Login.DataSetName = "data_Login";
            this.data_Login.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.input_Password);
            this.Controls.Add(this.input_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login - Customer Order";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox input_Username;
        private System.Windows.Forms.TextBox input_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_Close;
        private InventoryManagementDataSet data_Login;
    }
}

