namespace CustomerOrder
{
    partial class Main
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
            this.button_Close = new System.Windows.Forms.Button();
            this.combo_Company = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_Package = new System.Windows.Forms.ComboBox();
            this.button_SendUpdate = new System.Windows.Forms.Button();
            this.button_AddCompany = new System.Windows.Forms.Button();
            this.input_Update = new System.Windows.Forms.TextBox();
            this.label_Update = new System.Windows.Forms.Label();
            this.button_RemoveCompany = new System.Windows.Forms.Button();
            this.button_RemoveCustomerPackage = new System.Windows.Forms.Button();
            this.button_AddPackage = new System.Windows.Forms.Button();
            this.button_viewUpdates = new System.Windows.Forms.Button();
            this.data_CustomerSelect = new CustomerOrder.InventoryManagementDataSet();
            this.data_CustomerPackageSelect = new CustomerOrder.InventoryManagementDataSet();
            this.data_AddUpdate = new CustomerOrder.InventoryManagementDataSet();
            this.data_ViewUpdate = new CustomerOrder.InventoryManagementDataSet();
            this.button_CreatePackage = new System.Windows.Forms.Button();
            this.button_RemovePackage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerPackageSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_AddUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ViewUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(517, 442);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(222, 46);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // combo_Company
            // 
            this.combo_Company.FormattingEnabled = true;
            this.combo_Company.Location = new System.Drawing.Point(267, 67);
            this.combo_Company.Name = "combo_Company";
            this.combo_Company.Size = new System.Drawing.Size(390, 21);
            this.combo_Company.TabIndex = 2;
            this.combo_Company.SelectedIndexChanged += new System.EventHandler(this.combo_Company_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Package";
            // 
            // combo_Package
            // 
            this.combo_Package.Enabled = false;
            this.combo_Package.FormattingEnabled = true;
            this.combo_Package.Location = new System.Drawing.Point(267, 116);
            this.combo_Package.Name = "combo_Package";
            this.combo_Package.Size = new System.Drawing.Size(390, 21);
            this.combo_Package.TabIndex = 6;
            // 
            // button_SendUpdate
            // 
            this.button_SendUpdate.Enabled = false;
            this.button_SendUpdate.Location = new System.Drawing.Point(267, 376);
            this.button_SendUpdate.Name = "button_SendUpdate";
            this.button_SendUpdate.Size = new System.Drawing.Size(222, 46);
            this.button_SendUpdate.TabIndex = 8;
            this.button_SendUpdate.Text = "Send Update";
            this.button_SendUpdate.UseVisualStyleBackColor = true;
            this.button_SendUpdate.Click += new System.EventHandler(this.button_SendUpdate_Click);
            // 
            // button_AddCompany
            // 
            this.button_AddCompany.Location = new System.Drawing.Point(12, 416);
            this.button_AddCompany.Name = "button_AddCompany";
            this.button_AddCompany.Size = new System.Drawing.Size(219, 31);
            this.button_AddCompany.TabIndex = 9;
            this.button_AddCompany.Text = "Add Customer";
            this.button_AddCompany.UseVisualStyleBackColor = true;
            this.button_AddCompany.Click += new System.EventHandler(this.button_AddCompany_Click);
            // 
            // input_Update
            // 
            this.input_Update.Enabled = false;
            this.input_Update.Location = new System.Drawing.Point(267, 168);
            this.input_Update.MaxLength = 500;
            this.input_Update.Multiline = true;
            this.input_Update.Name = "input_Update";
            this.input_Update.Size = new System.Drawing.Size(390, 188);
            this.input_Update.TabIndex = 10;
            // 
            // label_Update
            // 
            this.label_Update.AutoSize = true;
            this.label_Update.Location = new System.Drawing.Point(77, 168);
            this.label_Update.Name = "label_Update";
            this.label_Update.Size = new System.Drawing.Size(70, 13);
            this.label_Update.TabIndex = 11;
            this.label_Update.Text = "Enter Update";
            // 
            // button_RemoveCompany
            // 
            this.button_RemoveCompany.Location = new System.Drawing.Point(12, 457);
            this.button_RemoveCompany.Name = "button_RemoveCompany";
            this.button_RemoveCompany.Size = new System.Drawing.Size(219, 31);
            this.button_RemoveCompany.TabIndex = 12;
            this.button_RemoveCompany.Text = "Remove Customer";
            this.button_RemoveCompany.UseVisualStyleBackColor = true;
            this.button_RemoveCompany.Click += new System.EventHandler(this.button_RemoveCompany_Click);
            // 
            // button_RemoveCustomerPackage
            // 
            this.button_RemoveCustomerPackage.Location = new System.Drawing.Point(12, 376);
            this.button_RemoveCustomerPackage.Name = "button_RemoveCustomerPackage";
            this.button_RemoveCustomerPackage.Size = new System.Drawing.Size(219, 31);
            this.button_RemoveCustomerPackage.TabIndex = 14;
            this.button_RemoveCustomerPackage.Text = "Remove Customer Package";
            this.button_RemoveCustomerPackage.UseVisualStyleBackColor = true;
            this.button_RemoveCustomerPackage.Click += new System.EventHandler(this.button_RemovePackage_Click);
            // 
            // button_AddPackage
            // 
            this.button_AddPackage.Location = new System.Drawing.Point(12, 338);
            this.button_AddPackage.Name = "button_AddPackage";
            this.button_AddPackage.Size = new System.Drawing.Size(219, 31);
            this.button_AddPackage.TabIndex = 13;
            this.button_AddPackage.Text = "Add Customer Package";
            this.button_AddPackage.UseVisualStyleBackColor = true;
            this.button_AddPackage.Click += new System.EventHandler(this.button_AddPackage_Click);
            // 
            // button_viewUpdates
            // 
            this.button_viewUpdates.Enabled = false;
            this.button_viewUpdates.Location = new System.Drawing.Point(267, 442);
            this.button_viewUpdates.Name = "button_viewUpdates";
            this.button_viewUpdates.Size = new System.Drawing.Size(222, 46);
            this.button_viewUpdates.TabIndex = 15;
            this.button_viewUpdates.Text = "View Updates";
            this.button_viewUpdates.UseVisualStyleBackColor = true;
            this.button_viewUpdates.Click += new System.EventHandler(this.button_viewUpdates_Click);
            // 
            // data_CustomerSelect
            // 
            this.data_CustomerSelect.DataSetName = "data_CustomerSelect";
            this.data_CustomerSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_CustomerPackageSelect
            // 
            this.data_CustomerPackageSelect.DataSetName = "data_CustomerPackageSelect";
            this.data_CustomerPackageSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_AddUpdate
            // 
            this.data_AddUpdate.DataSetName = "data_AddUpdate";
            this.data_AddUpdate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_ViewUpdate
            // 
            this.data_ViewUpdate.DataSetName = "data_ViewUpdate";
            this.data_ViewUpdate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_CreatePackage
            // 
            this.button_CreatePackage.Location = new System.Drawing.Point(12, 264);
            this.button_CreatePackage.Name = "button_CreatePackage";
            this.button_CreatePackage.Size = new System.Drawing.Size(219, 31);
            this.button_CreatePackage.TabIndex = 16;
            this.button_CreatePackage.Text = "Create New Package";
            this.button_CreatePackage.UseVisualStyleBackColor = true;
            // 
            // button_RemovePackage
            // 
            this.button_RemovePackage.Location = new System.Drawing.Point(12, 301);
            this.button_RemovePackage.Name = "button_RemovePackage";
            this.button_RemovePackage.Size = new System.Drawing.Size(219, 31);
            this.button_RemovePackage.TabIndex = 17;
            this.button_RemovePackage.Text = "Remove Package";
            this.button_RemovePackage.UseVisualStyleBackColor = true;
            this.button_RemovePackage.Click += new System.EventHandler(this.button_RemovePackage_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 500);
            this.Controls.Add(this.button_RemovePackage);
            this.Controls.Add(this.button_CreatePackage);
            this.Controls.Add(this.button_viewUpdates);
            this.Controls.Add(this.button_RemoveCustomerPackage);
            this.Controls.Add(this.button_AddPackage);
            this.Controls.Add(this.button_RemoveCompany);
            this.Controls.Add(this.label_Update);
            this.Controls.Add(this.input_Update);
            this.Controls.Add(this.button_AddCompany);
            this.Controls.Add(this.button_SendUpdate);
            this.Controls.Add(this.combo_Package);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Company);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Customer Order";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerPackageSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_AddUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ViewUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.ComboBox combo_Company;
        private System.Windows.Forms.Label label1;
        private InventoryManagementDataSet data_CustomerSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_Package;
        private System.Windows.Forms.Button button_SendUpdate;
        private System.Windows.Forms.Button button_AddCompany;
        private InventoryManagementDataSet data_CustomerPackageSelect;
        private System.Windows.Forms.TextBox input_Update;
        private System.Windows.Forms.Label label_Update;
        private System.Windows.Forms.Button button_RemoveCompany;
        private System.Windows.Forms.Button button_RemoveCustomerPackage;
        private System.Windows.Forms.Button button_AddPackage;
        private InventoryManagementDataSet data_AddUpdate;
        private System.Windows.Forms.Button button_viewUpdates;
        private InventoryManagementDataSet data_ViewUpdate;
        private System.Windows.Forms.Button button_CreatePackage;
        private System.Windows.Forms.Button button_RemovePackage;
    }
}