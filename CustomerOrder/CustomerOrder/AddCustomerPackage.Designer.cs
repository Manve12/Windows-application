namespace CustomerOrder
{
    partial class AddCustomerPackage
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
            this.label_SelectCompany = new System.Windows.Forms.Label();
            this.combo_Company = new System.Windows.Forms.ComboBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddPackage = new System.Windows.Forms.Button();
            this.label_Package = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.data_CustomerSelect = new CustomerOrder.InventoryManagementDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SelectCompany
            // 
            this.label_SelectCompany.AutoSize = true;
            this.label_SelectCompany.Location = new System.Drawing.Point(13, 13);
            this.label_SelectCompany.Name = "label_SelectCompany";
            this.label_SelectCompany.Size = new System.Drawing.Size(84, 13);
            this.label_SelectCompany.TabIndex = 0;
            this.label_SelectCompany.Text = "Select Company";
            // 
            // combo_Company
            // 
            this.combo_Company.FormattingEnabled = true;
            this.combo_Company.Location = new System.Drawing.Point(16, 39);
            this.combo_Company.Name = "combo_Company";
            this.combo_Company.Size = new System.Drawing.Size(256, 21);
            this.combo_Company.TabIndex = 1;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(16, 209);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(250, 40);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_AddPackage
            // 
            this.button_AddPackage.Location = new System.Drawing.Point(16, 153);
            this.button_AddPackage.Name = "button_AddPackage";
            this.button_AddPackage.Size = new System.Drawing.Size(250, 40);
            this.button_AddPackage.TabIndex = 3;
            this.button_AddPackage.Text = "Add Package";
            this.button_AddPackage.UseVisualStyleBackColor = true;
            // 
            // label_Package
            // 
            this.label_Package.AutoSize = true;
            this.label_Package.Location = new System.Drawing.Point(13, 80);
            this.label_Package.Name = "label_Package";
            this.label_Package.Size = new System.Drawing.Size(81, 13);
            this.label_Package.TabIndex = 4;
            this.label_Package.Text = "Package Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 5;
            // 
            // data_CustomerSelect
            // 
            this.data_CustomerSelect.DataSetName = "data_CustomerSelect";
            this.data_CustomerSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Package);
            this.Controls.Add(this.button_AddPackage);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.combo_Company);
            this.Controls.Add(this.label_SelectCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPackage";
            this.Text = "AddPackage";
            this.Load += new System.EventHandler(this.AddPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SelectCompany;
        private System.Windows.Forms.ComboBox combo_Company;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddPackage;
        private System.Windows.Forms.Label label_Package;
        private System.Windows.Forms.TextBox textBox1;
        private InventoryManagementDataSet data_CustomerSelect;
    }
}