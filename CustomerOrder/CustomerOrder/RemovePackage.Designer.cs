namespace CustomerOrder
{
    partial class RemovePackage
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
            this.combo_Package = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_RemovePackage = new System.Windows.Forms.Button();
            this.data_RemovePackage = new CustomerOrder.InventoryManagementDataSet();
            this.data_PackageSelect = new CustomerOrder.InventoryManagementDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.data_RemovePackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_PackageSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 98);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(260, 23);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // combo_Package
            // 
            this.combo_Package.FormattingEnabled = true;
            this.combo_Package.Location = new System.Drawing.Point(12, 31);
            this.combo_Package.Name = "combo_Package";
            this.combo_Package.Size = new System.Drawing.Size(260, 21);
            this.combo_Package.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Package";
            // 
            // button_RemovePackage
            // 
            this.button_RemovePackage.Location = new System.Drawing.Point(12, 69);
            this.button_RemovePackage.Name = "button_RemovePackage";
            this.button_RemovePackage.Size = new System.Drawing.Size(260, 23);
            this.button_RemovePackage.TabIndex = 3;
            this.button_RemovePackage.Text = "Remove Package";
            this.button_RemovePackage.UseVisualStyleBackColor = true;
            this.button_RemovePackage.Click += new System.EventHandler(this.button_RemovePackage_Click);
            // 
            // data_RemovePackage
            // 
            this.data_RemovePackage.DataSetName = "data_RemovePackage";
            this.data_RemovePackage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_PackageSelect
            // 
            this.data_PackageSelect.DataSetName = "data_PackageSelect";
            this.data_PackageSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RemovePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 139);
            this.Controls.Add(this.button_RemovePackage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Package);
            this.Controls.Add(this.button_Close);
            this.Name = "RemovePackage";
            this.Text = "RemovePackage";
            this.Load += new System.EventHandler(this.RemovePackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_RemovePackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_PackageSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.ComboBox combo_Package;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_RemovePackage;
        private InventoryManagementDataSet data_RemovePackage;
        private InventoryManagementDataSet data_PackageSelect;
    }
}