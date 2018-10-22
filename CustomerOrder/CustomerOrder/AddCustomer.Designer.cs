namespace CustomerOrder
{
    partial class AddCustomer
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
            this.button_AddCompany = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_CustomerName = new System.Windows.Forms.TextBox();
            this.data_AddCustomer = new CustomerOrder.InventoryManagementDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.data_AddCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 143);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(260, 29);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_AddCompany
            // 
            this.button_AddCompany.Location = new System.Drawing.Point(12, 93);
            this.button_AddCompany.Name = "button_AddCompany";
            this.button_AddCompany.Size = new System.Drawing.Size(260, 29);
            this.button_AddCompany.TabIndex = 1;
            this.button_AddCompany.Text = "Add Customer";
            this.button_AddCompany.UseVisualStyleBackColor = true;
            this.button_AddCompany.Click += new System.EventHandler(this.button_AddCompany_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // input_CustomerName
            // 
            this.input_CustomerName.Location = new System.Drawing.Point(12, 44);
            this.input_CustomerName.Name = "input_CustomerName";
            this.input_CustomerName.Size = new System.Drawing.Size(260, 20);
            this.input_CustomerName.TabIndex = 3;
            // 
            // data_AddCustomer
            // 
            this.data_AddCustomer.DataSetName = "data_AddCustomer";
            this.data_AddCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.input_CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddCompany);
            this.Controls.Add(this.button_Close);
            this.Name = "AddCustomer";
            this.Text = "Add Customer";
            ((System.ComponentModel.ISupportInitialize)(this.data_AddCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_CustomerName;
        private InventoryManagementDataSet data_AddCustomer;
    }
}