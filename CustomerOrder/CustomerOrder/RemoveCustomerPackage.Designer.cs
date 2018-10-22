namespace CustomerOrder
{
    partial class RemoveCustomerPackage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_Company = new System.Windows.Forms.ComboBox();
            this.combo_Package = new System.Windows.Forms.ComboBox();
            this.button_RemovePackage = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.data_CustomerSelect = new CustomerOrder.InventoryManagementDataSet();
            this.data_CustomerPackageSelect = new CustomerOrder.InventoryManagementDataSet();
            this.data_RemoveCustomerPackage = new CustomerOrder.InventoryManagementDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerPackageSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RemoveCustomerPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Package";
            // 
            // combo_Company
            // 
            this.combo_Company.FormattingEnabled = true;
            this.combo_Company.Location = new System.Drawing.Point(12, 34);
            this.combo_Company.Name = "combo_Company";
            this.combo_Company.Size = new System.Drawing.Size(259, 21);
            this.combo_Company.TabIndex = 2;
            this.combo_Company.SelectedIndexChanged += new System.EventHandler(this.combo_Company_SelectedIndexChanged);
            // 
            // combo_Package
            // 
            this.combo_Package.Enabled = false;
            this.combo_Package.FormattingEnabled = true;
            this.combo_Package.Location = new System.Drawing.Point(12, 94);
            this.combo_Package.Name = "combo_Package";
            this.combo_Package.Size = new System.Drawing.Size(259, 21);
            this.combo_Package.TabIndex = 3;
            // 
            // button_RemovePackage
            // 
            this.button_RemovePackage.Location = new System.Drawing.Point(12, 130);
            this.button_RemovePackage.Name = "button_RemovePackage";
            this.button_RemovePackage.Size = new System.Drawing.Size(259, 31);
            this.button_RemovePackage.TabIndex = 4;
            this.button_RemovePackage.Text = "Remove Package";
            this.button_RemovePackage.UseVisualStyleBackColor = true;
            this.button_RemovePackage.Click += new System.EventHandler(this.button_RemovePackage_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 167);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(259, 31);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
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
            // data_RemoveCustomerPackage
            // 
            this.data_RemoveCustomerPackage.DataSetName = "data_RemoveCustomerPackage";
            this.data_RemoveCustomerPackage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RemoveCustomerPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_RemovePackage);
            this.Controls.Add(this.combo_Package);
            this.Controls.Add(this.combo_Company);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RemoveCustomerPackage";
            this.Text = "RemovePackage";
            this.Load += new System.EventHandler(this.RemovePackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerPackageSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RemoveCustomerPackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_Company;
        private System.Windows.Forms.ComboBox combo_Package;
        private System.Windows.Forms.Button button_RemovePackage;
        private System.Windows.Forms.Button button_Close;
        private InventoryManagementDataSet data_CustomerSelect;
        private InventoryManagementDataSet data_CustomerPackageSelect;
        private InventoryManagementDataSet data_RemoveCustomerPackage;
    }
}