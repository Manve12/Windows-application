namespace CustomerOrder
{
    partial class RemoveCustomer
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
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.combo_Company = new System.Windows.Forms.ComboBox();
            this.data_CustomerSelect = new CustomerOrder.InventoryManagementDataSet();
            this.data_RemoveCustomer = new CustomerOrder.InventoryManagementDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RemoveCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Company";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 102);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(260, 23);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(12, 73);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(260, 23);
            this.button_Remove.TabIndex = 2;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // combo_Company
            // 
            this.combo_Company.FormattingEnabled = true;
            this.combo_Company.Location = new System.Drawing.Point(12, 31);
            this.combo_Company.Name = "combo_Company";
            this.combo_Company.Size = new System.Drawing.Size(260, 21);
            this.combo_Company.TabIndex = 3;
            // 
            // data_CustomerSelect
            // 
            this.data_CustomerSelect.DataSetName = "data_CustomerSelect";
            this.data_CustomerSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_RemoveCustomer
            // 
            this.data_RemoveCustomer.DataSetName = "data_RemoveCustomer";
            this.data_RemoveCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.combo_Company);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RemoveCustomer";
            this.Text = "RemoveCompany";
            this.Load += new System.EventHandler(this.RemoveCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_CustomerSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_RemoveCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.ComboBox combo_Company;
        private InventoryManagementDataSet data_CustomerSelect;
        private InventoryManagementDataSet data_RemoveCustomer;
    }
}